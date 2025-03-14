using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperTimer : MonoBehaviour
{
    public bool overIncin = false;
    public float deleteTimer = 3;
    float Timer = 0;
    bool inIncinerator = false;

    private void Update()
    {
        if (!inIncinerator)
        {
            Timer += Time.deltaTime;

            if (Timer > deleteTimer)
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.CompareTag("Incinerator"))
        {
            Debug.Log("EnteredIncin");
            inIncinerator = true;
        } 
    }
    private void OnTriggerExit(Collider collision)
    {
        Debug.Log("ExitIncin");
        inIncinerator = false;
    }
}
