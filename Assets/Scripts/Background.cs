using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Background : MonoBehaviour
{

    // Start is called before the first frame update
    void Update() {
        if(Input.GetMouseButtonDown(0)) {
            GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag("Panel");
 
            foreach(GameObject go in gameObjectArray) {
                go.SetActive(false);
            }
        }         
    }
}
