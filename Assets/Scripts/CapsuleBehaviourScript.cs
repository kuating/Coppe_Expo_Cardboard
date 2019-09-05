using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleBehaviourScript : MonoBehaviour
{
    Animator animator;
    private bool isPointing;
    public float pointTimeCap = 200f;
    private float counter;
    private bool selected;


    // Start is called before the first frame update
    void Start()
    {
        isPointing = false;
        selected = false;
        counter = 0f;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private bool IsDancing()
    {
        return (animator.GetBool("isDancing"));
    }

    public void SetDance()
    {
        if (IsDancing()) animator.SetBool("isDancing", false);
        else animator.SetBool("isDancing", true);
    }

    public float GetPointCompletion()
    {
        return counter/pointTimeCap;
    }

    public void EventPoint(bool over)
    {
        if (!isPointing)
        {
            if (over)
            {
                isPointing = true;
                BeginCount();
                return;
            }
        }
        else if (!over)
        {
            isPointing = false;
            selected = false;
        }
    }

    private void BeginCount()
    {
        counter = 0f;
        Invoke("Count", 0f);
    }

    private void Count()
    {
        if (!selected && isPointing)
        {
            if (counter >= pointTimeCap)
            {
                DoOnSelect();
            }
            else
            {
                counter += 1f;
                Invoke("Count", 0.01f);
            }
        }
        else counter = 0f;
    }

    private void DoOnSelect()
    {
        selected = true;
        SetDance();
    }
}
