using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSelect : MonoBehaviour
{
    public GameObject playerCamera;
    public bool lookingDown;
    private Color tempColor;

    void Update()
    {

        if (playerCamera.transform.rotation.x > 40)
        {
            lookingDown = true;
            for (int i = 0; i < this.transform.childCount; i++) {
                tempColor = transform.GetChild(i).GetComponent<MeshRenderer>().material.color;
                tempColor.a = 1;
                transform.GetChild(i).GetComponent<MeshRenderer>().material.SetColor("_Color", tempColor);
            }
        }
        else/* if (playerCamera.transform.localRotation.x <= 40)*/
        {
            lookingDown = false;
            for (int i = 0; i < this.transform.childCount; i++)
            {
                tempColor = transform.GetChild(i).GetComponent<MeshRenderer>().material.color;
                tempColor.a = 0;
                transform.GetChild(i).GetComponent<MeshRenderer>().material.SetColor("_Color", tempColor);
            }
        }
        
    }
}
