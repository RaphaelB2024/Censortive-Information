using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperTimer : MonoBehaviour
{
    public LayerMask incinerator;
    public GameObject hit;
    public float deleteTimer = 3;
    float Timer = 0;
    bool timerOn = true;

    private void Update()
    {
        var ray = new Ray(this.transform.position, this.transform.forward);
        RaycastHit hit;
        Physics.Raycast(ray, out hit);
        {
            Debug.Log(hit.transform.gameObject);
        }

        if (timerOn)
        {
            Timer += Time.deltaTime;

            if (Timer > deleteTimer)
            {
                Destroy(gameObject);
            }
        }
    }


}
