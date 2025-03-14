using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperTimer : MonoBehaviour
{
    public LayerMask incinerator;
    public bool overIncin = false;
    public float incinCheckDist;
    private float bufferCheckDist = 0.1f;
    public float deleteTimer = 3;
    float Timer = 0;
    bool timerOn = true;

    private void Update()
    {
        incinCheckDist = (GetComponent<CapsuleCollider>().height / 2) + bufferCheckDist;

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
