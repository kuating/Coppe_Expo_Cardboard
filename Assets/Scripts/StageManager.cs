using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class StageManager : MonoBehaviour
{
    public VideoClip[] clips;
    public Material[] materials;
    public int currentId = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    static public void TeleportToRoom(int selectedId, GameObject selectedLogo)
    {
        VideoPlayer videoM = GameObject.FindGameObjectWithTag("Video").GetComponent<VideoPlayer>();
        StageManager manager = GameObject.FindGameObjectWithTag("StageManager").GetComponent<StageManager>();
        videoM.clip = manager.clips[selectedId];
        selectedLogo.GetComponent<MeshRenderer>().material = manager.materials[manager.currentId];
        selectedLogo.GetComponent<LogoTeleporter>().logoId = manager.currentId;
        manager.currentId = selectedId;
    }
}
