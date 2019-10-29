using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GazeTimerBehaviour : MonoBehaviour
{
    //public Material material;

    private Animator animator;
    public GvrReticlePointer reticlePointer;
    public Material timerMaterial;
    public Image UITimer;
    private Transform canvasTransform;

    public float totalTime = 2;
    bool gvrStatus;
    public float gvrTimer;

    public int distanceOfRay;
    private RaycastResult _hit;
    private bool isClicked = false;

    private void Start()
    {
        //Graphic graphic = GetComponent<Graphic>();
        //graphic.material = this.material;
        
        canvasTransform = UITimer.transform.parent; 
        //rendererComponent.sortingOrder = reticlePointer.reticleSortingOrder;
        //Canvas.GetDefaultCanvasMaterial().shader = timerMaterial.shader;
        animator = UITimer.GetComponent<Animator>();
    }

    void Update()
    {
        if (gvrStatus)
        {
            if (gvrTimer >= 0 && gvrTimer < totalTime)
            {
                gvrTimer += Time.deltaTime;
                UITimer.fillAmount = gvrTimer / totalTime;
            }
        }

        RaycastResult raycastResult = GvrPointerInputModule.CurrentRaycastResult;

        canvasTransform.position = raycastResult.worldPosition;//new Vector3(canvasTransform.position.x, canvasTransform.position.y, raycastResult.distance != 0 ? raycastResult.distance:100);

        if (UITimer.fillAmount == 1 && !isClicked)
        {
            if (raycastResult.isValid)
            {
                isClicked = true;
                animator.SetBool("Complete", true);
                if (raycastResult.gameObject.CompareTag("Capsule"))
                {
                    raycastResult.gameObject.GetComponent<CapsuleBehaviourScript>().SetDance();
                }
                if (raycastResult.gameObject.CompareTag("Teleporter"))
                {
                    raycastResult.gameObject.GetComponent<TeleporterBehaviour>().TeleportPlayer();
                }
                if (raycastResult.gameObject.CompareTag("Item"))
                {
                    raycastResult.gameObject.GetComponent<Item>().Select();
                }
                Debug.DrawRay(raycastResult.screenPosition, (this.transform.position - raycastResult.worldPosition) * raycastResult.distance, Color.magenta);
            }
        }
        //PROBLEMATIC Debug.DrawRay(raycastResult.screenPosition, (this.transform.position - raycastResult.worldPosition) * raycastResult.distance, Color.magenta);
    }

    public void GVROn()
    {
        gvrStatus = true;
        animator.SetBool("Over", true);
    }

    public void GVROff()
    {
        gvrStatus = false;
        gvrTimer = 0;
        UITimer.fillAmount = 0;
        isClicked = false;
        animator.SetBool("Complete", false);
        animator.SetBool("Over", false);
    }
}
