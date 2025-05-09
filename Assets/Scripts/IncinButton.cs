using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncinButton : MonoBehaviour
{
    public Incinerator incin;
    public GameObject Fires;
    bool incineratable = true;
    Vector3 mousePos;

    private Vector3 GetMousePos()
    {
        return Camera.main.WorldToScreenPoint(transform.position);
    }

    private void OnMouseDown()
    {
        if (incineratable)
        {
            incin.incinerate = true;
            StartCoroutine(StartFire());
        }
    }
    private void OnMouseUp()
    {
        incin.incinerate = false;
    }

    IEnumerator StartFire()
    {
        Fires.SetActive(true);
        incineratable = false;
        yield return new WaitForSeconds(0.84f);
        Fires.SetActive(false);
        incineratable = true;
    }
}
