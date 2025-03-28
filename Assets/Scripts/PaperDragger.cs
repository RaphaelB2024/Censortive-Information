using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

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
        mousePos.y = 15;
    }

    private void OnMouseDrag()
    {
       transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePos);
    }
}
