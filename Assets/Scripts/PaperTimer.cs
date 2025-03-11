using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperTimer : MonoBehaviour
{
    public float deleteTimer = 3;
    float Timer = 0;

    private void Update()
    {
        Timer += Time.deltaTime;

        if (Timer > deleteTimer)
        {
            Destroy(gameObject);
        }
    }

}
