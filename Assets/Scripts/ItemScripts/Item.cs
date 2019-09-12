using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public bool isCollectable = false;

    public string itemName = "[Insert Name]";
    public string itemDescription = "[Insert Description]";
    private TextMeshProUGUI itemNameText;
    private TextMeshProUGUI itemDescriptionText;
    private Canvas canvas;
    private Animator canvasAnimator;

    void Start()
    {
        canvas = this.transform.GetChild(0).GetComponent<Canvas>();
        canvasAnimator = canvas.GetComponent<Animator>();
        itemNameText = canvas.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        itemDescriptionText = canvas.transform.GetChild(1).GetComponent<TextMeshProUGUI>();
        itemNameText.text = itemName;
        itemDescriptionText.text = itemDescription;
    }

    void Update()
    {
        
    }

    public void Select()
    {
        if (canvasAnimator.GetBool("isSelected")) canvasAnimator.SetBool("isSelected", false);
        else canvasAnimator.SetBool("isSelected", true);
    }
}
