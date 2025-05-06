using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperTray : MonoBehaviour
{
    public DayManager DayManager;
    [SerializeField] private AudioClip[] goodPaperClips;
    [SerializeField] private AudioClip[] badPaperClips;
    [SerializeField] private AudioClip[] resistancePaperClips;
    [SerializeField] private AudioClip papernoise;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("GoodPaper"))
        {
            soundManager.instance.PlayClip(papernoise, transform, 1f);
            Destroy(collision.gameObject);
            DayManager.quota++;
            Debug.Log("Quota: " + DayManager.quota);
            //soundManager.instance.PlayRandomClip(goodPaperClips, transform, 1f);

        }
        else if (collision.gameObject.CompareTag("BadPaper"))
        {
            soundManager.instance.PlayClip(papernoise, transform, 1f);
            Destroy(collision.gameObject);
            PointManager.GovernmentTolerance--;
            Debug.Log("GT: " + PointManager.GovernmentTolerance);
            //soundManager.instance.PlayRandomClip(badPaperClips, transform, 1f);
        }
        else if(collision.gameObject.CompareTag("ResistancePaper"))
        {
            Destroy(collision.gameObject);
            PointManager.GovernmentTolerance =- 1;
            PointManager.ResistancePoints ++;
            Debug.Log("GT = " + PointManager.GovernmentTolerance + " Res = " + PointManager.ResistancePoints);
            //soundManager.instance.PlayRandomClip(resistancePaperClips, transform, 1f);
        }
    }
}
