using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.GraphicsBuffer;

public class DayManager : MonoBehaviour
{
    public PointManager manager;
    public UIFade UIFade;
    public CamMover Mover;
    public GameObject Spawner;
    public GameObject mainCamera;
    public GameObject startText;


    public bool startDay = false;
    public float dayTimer = 0;
    public float dayLength = 0;

    IEnumerator Waiter()
    {
        yield return new WaitForSeconds(10f);
    }

    void Update()
    {
        if (startDay)
        {
            Mover.move = true;
            startText.SetActive(false);
            Spawner.SetActive(true);
            dayTimer += Time.deltaTime;
        }

        if(dayTimer >= dayLength)
        {
            startDay = false;
            Spawner.SetActive(false);
            UIFade.Fade();
            
            if (manager.GovernmentTolerance > 0 && manager.Quota >= manager.quotaTarget)
            {
                manager.GovernmentTolerance += Random.Range(0,5);
                StartCoroutine(Waiter());
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }

            else
            {
                StartCoroutine(Waiter());
                SceneManager.LoadScene("Death Ending");
            }
        }
    }
}