using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.GraphicsBuffer;

public class DayManager : MonoBehaviour
{
    public PointManager manager;
    public CamMover Mover;
    public GameObject Spawner;
    public GameObject mainCamera;
    public GameObject startText;


    public bool startDay = false;
    public float dayTimer = 0;
    public float dayLength = 0;

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
            if(manager.GovernmentTolerance > 0 && manager.Quota > 30)
            {
                startDay = false;
                Spawner.SetActive(false);
            }
        }
    }
}