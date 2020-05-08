using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DadChat : MonoBehaviour
{
    // public string textMessage;
    public GameObject inputField;
    public GameObject birthdayPrompt;
    public GameObject othersPrompt;
    public GameObject blankTextPrompt;

    public void SendTextMessage() {
        print(inputField.GetComponent<Text>());

        if (inputField.GetComponent<Text>() != null) {
            string textMessage = inputField.GetComponent<Text>().text;
            textMessage = textMessage.ToLower();
            print(textMessage);
            if (textMessage.Contains("birthday")) {
                Globals.sentBirthdayMsg = true;
                Globals.currentHealth -= 4;

                if (birthdayPrompt != null) {
                    birthdayPrompt.SetActive(true);
                }
            } else {
                if (othersPrompt != null) {
                    othersPrompt.SetActive(true);
                }
            }
        } else {
            if (blankTextPrompt != null) {
                blankTextPrompt.SetActive(true);
            }
        }
    }

    void Update() {
        if(Input.GetMouseButtonDown(0) && (birthdayPrompt.activeSelf || othersPrompt.activeSelf || blankTextPrompt.activeSelf)) {
            birthdayPrompt.SetActive(false);
            othersPrompt.SetActive(false);
            blankTextPrompt.SetActive(false);
        }        
    }
}
