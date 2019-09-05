using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleporterBehaviour : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TeleportPlayer()
    {
        player.transform.position = new Vector3(this.transform.position.x, player.transform.position.y, this.transform.position.z);
    }
}
