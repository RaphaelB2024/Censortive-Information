using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.GraphicsBuffer;

public class finalDayManager : MonoBehaviour
{
    public UIFade UIFade;
    public CamMover Mover;
    public GameObject Spawner;
    public GameObject mainCamera;
    public int quota;
    public int quotaTarget;


    public bool startDay = false;
    public float dayTimer = 0;
    public float dayLength = 0;

    IEnumerator GovEnd()
    {
        yield return new WaitForSeconds(6f);
        SceneManager.LoadScene("Government Ending");
    }

    IEnumerator ResEnd()
    {
        yield return new WaitForSeconds(6f);
        SceneManager.LoadScene("Resistance Ending");
    }

    IEnumerator LoseEnd()
    {
        yield return new WaitForSeconds(6f);
        SceneManager.LoadScene("Death Ending");
    }

    void Update()
    {
        if (startDay)
        {
            Mover.move = true;
            Spawner.SetActive(true);
            dayTimer += Time.deltaTime;
        }

        if (dayTimer >= dayLength)
        {
            startDay = false;
            Spawner.SetActive(false);
            UIFade.FadeIn();

            if (PointManager.GovernmentTolerance > -10 && quota >= quotaTarget && PointManager.ResistancePoints >= 6)
            {
                StartCoroutine(ResEnd());
            }

            else if (PointManager.GovernmentTolerance > -10 && quota >= quotaTarget)
            {
                StartCoroutine(GovEnd());
            }

            else
            {
                StartCoroutine(LoseEnd());
            }
        }
    }
}
