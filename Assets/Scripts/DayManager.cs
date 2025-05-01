using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.GraphicsBuffer;

public class DayManager : MonoBehaviour
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

    IEnumerator NextDay()
    {
        yield return new WaitForSeconds(6f);
        PointManager.GovernmentTolerance += Random.Range(0, 5);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
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

        if(dayTimer >= dayLength)
        {
            startDay = false;
            Spawner.SetActive(false);
            UIFade.FadeIn();
            
            if (PointManager.GovernmentTolerance > 0 && quota >= quotaTarget)
            {
                StartCoroutine(NextDay());
            }

            else
            {
                StartCoroutine(LoseEnd());
            }
        }
    }
}