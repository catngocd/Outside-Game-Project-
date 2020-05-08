using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Globals {
    public static int score = 0;
    public static bool sentBirthdayMsg = false;

    public static int currentHealth = 12;
    public static int time = 10;

    void Update() {
        Globals.time = Globals.time - 1;
        // Console.WriteLine(Globals.time);

        if(Globals.time < 0) {
            SceneManager.LoadScene(sceneName:"TitleScene");
        }
    }

}
