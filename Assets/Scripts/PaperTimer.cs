using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperTimer : MonoBehaviour
{
    public float deleteTimer = 3;
    float Timer = 0;
    bool timerOn = true;

    private void Update()
    {
        if (timerOn)
        {
            Timer += Time.deltaTime;

            if (Timer > deleteTimer)
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
            timerOn = false;
        }
    }

   /* private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit Incinerator");
        timerOn = true;
    }*/

}
