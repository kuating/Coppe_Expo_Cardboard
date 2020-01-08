using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Video;

public class LogoTeleporter : MonoBehaviour
{
    public GameObject player;
    //private bool moving = false;
    //private Vector3 destination;
    public VideoClip videoClip;
    private GameObject videoM;
    /*public Material mat;
    */

    void Start()
    {
        videoM = GameObject.FindGameObjectWithTag("Video");
    }

    void Update()
    {

    }

    public void TeleportToRoom()
    {
        videoM.GetComponent<VideoPlayer>().clip = videoClip;
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