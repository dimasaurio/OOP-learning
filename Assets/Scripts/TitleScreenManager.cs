using UnityEngine;


public class TitleScreenManager : MonoBehaviour
{
    public GameObject titleScreenPanel;
    public bool gameStarted = false;

    public void StartGame()
    {
        titleScreenPanel.SetActive(false);
        gameStarted = true;
        // Lock the cursor and hide it
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}