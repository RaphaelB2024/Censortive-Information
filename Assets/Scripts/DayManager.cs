using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DayManager : MonoBehaviour
{
    public PointManager manager;

    public GameObject mainCamera;
    public GameObject camTarget;
    private float speed = 1.5f;

    public bool startDay = false;
    public float dayTimer = 0;
    public float dayLength = 0;

    void Update()
    {
        if (startDay)
        {
            Debug.Log("StartDay");
            Reposition();
            dayTimer += Time.deltaTime;
        }

        if(dayTimer >= dayLength)
        {
            if(manager.GovernmentTolerance > 0 && manager.Quota > 30)
            {
                
            }
        }
    }

    void Reposition()
    { 
        transform.position = Vector3.MoveTowards(transform.position, camTarget.transform.position, speed * Time.deltaTime);
    }
}