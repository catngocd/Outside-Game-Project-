using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public GameObject Panel;

    // Start is called before the first frame update
    void Update() {
        if(Input.GetMouseButtonDown(0)) {
            if(Panel != null) {
                bool isActive = Panel.activeSelf;
                if (isActive) {
                    Panel.SetActive(false);
                }
            } 
        }         
    }
}
