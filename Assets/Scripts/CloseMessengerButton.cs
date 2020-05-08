using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CloseMessengerButton : MonoBehaviour
{
    public void ChangeScene() {
        // Globals.currentHealth = 10;
        SceneManager.LoadScene(sceneName:"MainScene");
    }
}
