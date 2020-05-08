using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour {
    public static float timeStart = 60;
    public Text textBox;

    // Start is called before the first frame update
    void Start() {
        textBox.text = timeStart.ToString();
    }

    // Update is called once per frame
    void Update() {
        timeStart += Time.deltaTime * 4;
        float hours = timeStart / 60;

        if (Mathf.FloorToInt(hours) > 7) {
            if (Globals.currentHealth > 0) {
                SceneManager.LoadScene(sceneName:"BadEnding1Scene");
            } else {
                SceneManager.LoadScene(sceneName:"GoodEndingScene");
            }
        } 

        float minutes = timeStart % 60;

        if (minutes < 10) {
            textBox.text = "0" + Mathf.FloorToInt(hours).ToString() + ":0" + Mathf.Round(minutes).ToString() + " AM";
        } else {
            textBox.text = "0" + Mathf.FloorToInt(hours).ToString() + ":" + Mathf.Round(minutes).ToString() + " AM";
        }
    }
}
