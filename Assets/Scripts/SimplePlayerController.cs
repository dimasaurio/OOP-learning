using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    public Camera playerCamera;
    public float speed = 5.0f;
    public float sensitivity = 2.0f;
    public bool invertY = false;

    private Rigidbody rb;
    private float yaw = 0.0f;
    private float pitch = 0.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        // Lock the cursor to the center of the screen
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        // Prevent Rigidbody from rotating automatically.
        rb.freezeRotation = true;
    }

    void Update()
    {
        // Movement
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        Vector3 newPosition = transform.position + transform.TransformDirection(movement) * speed * Time.deltaTime;
        rb.MovePosition(newPosition);

        // Mouse Look (horizontal - player, vertical - camera)
        yaw += sensitivity * Input.GetAxis("Mouse X");
        transform.eulerAngles = new Vector3(0, yaw, 0);

        if (invertY)
        {
            pitch += sensitivity * Input.GetAxis("Mouse Y");
        }
        else
        {
            pitch -= sensitivity * Input.GetAxis("Mouse Y");
        }

        pitch = Mathf.Clamp(pitch, -90f, 90f);
        playerCamera.transform.localEulerAngles = new Vector3(pitch, 0.0f, 0.0f);
    }
}