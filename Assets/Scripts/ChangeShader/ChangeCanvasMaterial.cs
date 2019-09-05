using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class ChangeCanvasMaterial : MonoBehaviour
{

    public Material material;
    public bool apply = false;

    private void Update()
    {
        if (apply)
        {
            apply = false;
            Graphic graphic = GetComponent<Graphic>();
            graphic.material = this.material;
        }
    }
}