using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperTray : MonoBehaviour
{
    int goodPapers = 0;
    int badPapers = 0;
    public float timer = 10;
    public PointManager manager;

    private void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            Deliver();
            timer = 10;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("GoodPaper"))
        {
            goodPapers++;
        }
        else if (collision.gameObject.CompareTag("BadPaper"))
        {
            badPapers++;
        }
    }

    void Deliver()
    {
        manager.GovernmentTolerance -= badPapers;
        Debug.Log(manager.GovernmentTolerance);
        manager.Quota += goodPapers;
        Debug.Log(manager.Quota);
    }
}
