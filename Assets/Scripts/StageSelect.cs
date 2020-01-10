using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSelect : MonoBehaviour
{
    public GameObject playerCamera;
    public bool lookingDown;
    private Color tempColor;
    private Animator anim;

    private void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    void Update()
    {


        if (playerCamera.transform.eulerAngles.x > 40)
        {
            if (lookingDown == false) { lookingDown = true; this.transform.DORotate(new Vector3(0, playerCamera.transform.eulerAngles.y, 0), 1/2); }
            anim.SetBool("Over", true);

            /*for (int i = 0; i < this.transform.childCount; i++) {
                tempColor = transform.GetChild(i).GetComponent<MeshRenderer>().material.color;
                tempColor.a = 1;
                transform.GetChild(i).GetComponent<MeshRenderer>().material.SetColor("_Color", tempColor);
            }*/
        }
        else/* if (playerCamera.transform.localRotation.x <= 40)*/
        {
            lookingDown = false;
            //this.transform.DORotate(new Vector3(0, playerCamera.transform.eulerAngles.y, 0), 1);
            anim.SetBool("Over", false);
            /*for (int i = 0; i < this.transform.childCount; i++)
            {
                tempColor = transform.GetChild(i).GetComponent<MeshRenderer>().material.color;
                tempColor.a = 0;
                transform.GetChild(i).GetComponent<MeshRenderer>().material.SetColor("_Color", tempColor);
            }*/
        }
        
    }
}
