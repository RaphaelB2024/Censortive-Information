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

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("GoodPaper"))
        {
            goodPapers++;
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("BadPaper"))
        {
            badPapers++;
            Destroy(collision.gameObject);
        }
    }

    void Deliver()
    {
        manager.GovernmentTolerance -= badPapers;
        Debug.Log("GT = " + manager.GovernmentTolerance);
        manager.Quota += goodPapers;
        Debug.Log("Q = " + manager.Quota);
    }
}
