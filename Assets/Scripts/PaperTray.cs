using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperTray : MonoBehaviour
{
    public PointManager manager;
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
            manager.Quota++;
            Debug.Log("Quota: " + manager.Quota);
            Debug.Log("GT: " + manager.GovernmentTolerance);
            soundManager.instance.PlayRandomClip(goodPaperClips, transform, 1f);

        }
        else if (collision.gameObject.CompareTag("BadPaper"))
        {
            soundManager.instance.PlayClip(papernoise, transform, 1f);
            Destroy(collision.gameObject);
            manager.GovernmentTolerance--;
            Debug.Log("GT: " + manager.GovernmentTolerance);
            soundManager.instance.PlayRandomClip(badPaperClips, transform, 1f);
        }
        else if(collision.gameObject.CompareTag("ResistancePaper"))
        {
            manager.GovernmentTolerance += 0.5f;
            Destroy(collision.gameObject);
            manager.GovernmentTolerance =- 1;
            manager.ResistancePoints ++;
            Debug.Log("GT = " + manager.GovernmentTolerance + " Res = " + manager.ResistancePoints);
            soundManager.instance.PlayRandomClip(resistancePaperClips, transform, 1f);
        }
    }
}
