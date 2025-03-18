using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncinButton : MonoBehaviour
{
    public Incinerator incin;
    Vector3 mousePos;

    private Vector3 GetMousePos()
    {
        return Camera.main.WorldToScreenPoint(transform.position);
    }

    private void OnMouseDown()
    {

    }
}
