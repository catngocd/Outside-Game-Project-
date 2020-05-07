using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMessenger : MonoBehaviour
{
    public void ChangeScene() {
        SceneManager.LoadScene(sceneName:"MessengerScene");
    }
}
