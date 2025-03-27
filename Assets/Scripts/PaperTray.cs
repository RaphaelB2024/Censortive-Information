using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperTray : MonoBehaviour
{
    int goodPapers = 0;
    int badPapers = 0;
    public PointManager manager;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("GoodPaper"))
        {
            goodPapers++;
            Debug.Log("good papers: " + goodPapers);
        }
        else if (collision.gameObject.CompareTag("BadPaper"))
        {
            badPapers++;
            Debug.Log("bad papers: " + badPapers);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("GoodPaper"))
        {
            goodPapers--;
            Debug.Log("good papers: " + badPapers);
        }

        else if (other.gameObject.CompareTag("BadPaper"))
        {
            badPapers--;
            Debug.Log("bad papers: " + badPapers);
        }
    }
}
