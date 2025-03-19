using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperDragger : MonoBehaviour
{
    Vector3 mousePos;

    private Vector3 GetMousePos()
    {
        return Camera.main.WorldToScreenPoint(transform.position);
    }

    private void OnMouseDown()
    {
        mousePos = Input.mousePosition - GetMousePos();
        mousePos.y = -10;
    }

    private void OnMouseDrag()
    {
       transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePos);
    }
}
