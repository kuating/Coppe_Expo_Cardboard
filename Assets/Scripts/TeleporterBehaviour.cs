using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TeleporterBehaviour : MonoBehaviour
{
    public GameObject player;
    private bool moving = false;
    private Vector3 destination;
    [SerializeField]
    private float step = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (moving == true)
        {
            if (player.transform.position != destination)
            {
                player.transform.position = Vector3.MoveTowards(player.transform.position, destination, Time.deltaTime*step);

            }
            else moving = false;
        }*/
    }

    private void FixedUpdate()
    {
        
    }

    public void TeleportPlayer()
    {
        player.transform.DOMove(new Vector3(this.transform.position.x, player.transform.position.y, this.transform.position.z), step);
        /*if (moving == false)
        {
            destination = new Vector3(this.transform.position.x, player.transform.position.y, this.transform.position.z);
            moving = true;
        }*/
    }
}
