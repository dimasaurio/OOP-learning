using UnityEngine;
using TMPro;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    public TextMeshProUGUI messageText;
    public float messageDuration = 3.0f;
    private float messageTimer = 0f;
    public Camera playerCamera;
    public float speed = 5.0f;
    public float sensitivity = 2.0f;
    public bool invertY = false;
    public TitleScreenManager titleScreenManager;

    private Rigidbody rb;
    private float yaw = 0.0f;
    private float pitch = 0.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // Prevent Rigidbody from rotating automatically.
        rb.freezeRotation = true;
    }

    void Update()
    {
        // Check if game has started
        if (!titleScreenManager.gameStarted)
        {
            return;
        }

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

        // Message Timer to vanish the message
        if (messageTimer > 0)
        {
            messageTimer -= Time.deltaTime;
            if (messageTimer <= 0)
            {
                messageText.text = "";
            }
        }

        // Player Interaction
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                IReadable readable = hit.transform.GetComponent<Book>(); //ABSTRACTION
                if (readable != null)
                {
                    readable.Read(this);
                }
            }
        }

    }
    public void DisplayMessage(string message)
    {
        messageText.text = message;
        messageTimer = messageDuration;
    }
}
