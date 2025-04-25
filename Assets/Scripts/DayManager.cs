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

    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
    }

    IEnumerator NextDay()
    {
        yield return new WaitForSeconds(6f);
        manager.GovernmentTolerance += Random.Range(0, 5);
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
            startText.SetActive(false);
            Spawner.SetActive(true);
            dayTimer += Time.deltaTime;
        }

        if(dayTimer >= dayLength)
        {
            startDay = false;
            Spawner.SetActive(false);
            UIFade.FadeIn();

            if()
            {

            }
            
            else if (manager.GovernmentTolerance > 0 && manager.Quota >= manager.quotaTarget)
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