using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayButton : MonoBehaviour
{
    public DayManager manager;
    Vector3 mousePos;
    [SerializeField] private AudioClip musicClip;

    private Vector3 GetMousePos()
    {
        return Camera.main.WorldToScreenPoint(transform.position);
    }

    private void OnMouseDown()
    {
        manager.startDay = true;
        soundManager.instance.playClip(musicClip, transform, 1f);
    }
}
