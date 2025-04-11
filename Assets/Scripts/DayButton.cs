using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayButton : MonoBehaviour
{
    public DayManager manager;
    public GameObject music;
    Vector3 mousePos;

    private Vector3 GetMousePos()
    {
        return Camera.main.WorldToScreenPoint(transform.position);
    }

    private void OnMouseDown()
    {
        manager.startDay = true;
        music.SetActive(true);
    }
}
