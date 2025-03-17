using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperTimer : MonoBehaviour
{
    public float deleteTimer = 3;
    float Timer = 0;
    bool timerOn = false;

    private void Update()
    {
        if (timerOn)
        {
            Timer += Time.deltaTime;
            Debug.Log("Time = " + Timer);

            if (Timer >= deleteTimer)
            {
                Destroy(gameObject);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Incinerator"))
        {
            Debug.Log("Entered Incinerator");
            timerOn = true;
        }
        else
        {
            timerOn = false;
        }
    }

}
