using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Messenger : MonoBehaviour
{

    public void OpenMessenger() {
        SceneManager.LoadScene(sceneName:"MessengerScene");
    }

    public void GoDadMessage() {
        SceneManager.LoadScene(sceneName:"DadChatScene");     
    }
}
