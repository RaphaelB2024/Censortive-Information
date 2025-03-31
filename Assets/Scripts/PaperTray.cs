using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperTray : MonoBehaviour
{
    public PointManager manager;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("GoodPaper"))
        {
            Destroy(collision.gameObject);
            manager.Quota++;
            Debug.Log("Quota: " + manager.Quota);
        }
        else if (collision.gameObject.CompareTag("BadPaper"))
        {
            Destroy(collision.gameObject);
            manager.GovernmentTolerance--;
            Debug.Log("GT: " + manager.GovernmentTolerance);
        }
        else if(collision.gameObject.CompareTag("ResistancePaper"))
        {
            Destroy (collision.gameObject);
            manager.GovernmentTolerance =- 2;
            manager.ResistancePoints ++;
            Debug.Log("GT = " + manager.GovernmentTolerance + " Res = " + manager.ResistancePoints);
        }
    }
}
