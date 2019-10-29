using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LogoTeleporter : MonoBehaviour
{
    public GameObject player;
    //private bool moving = false;
    //private Vector3 destination;
    public float step = 2f;
    public Material mat;

    void Update()
    {

    }

    public void TeleportToRoom()
    {
        //PLACEHOLDER
        RenderSettings.skybox = mat;
    }

    /*public void MovePlayer()
    {
        //playAnimation(); TODO
        player.transform.DOMove(new Vector3(this.transform.position.x, player.transform.position.y, this.transform.position.z), step);
    }*/

}

/*
 * TODO LIST:
 * 
 * -MovePlayer():
 *  Precisa interpolar entre A e B
 * 
 * -SKYBOX:
 *  Precisa de um Animator
 * 
 * 
 * 
 * 
 * */