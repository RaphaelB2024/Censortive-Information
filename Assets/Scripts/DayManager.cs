using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.GraphicsBuffer;

public class DayManager : MonoBehaviour
{
    public PointManager manager;

    public GameObject Spawner;
    public GameObject mainCamera;
    public Transform camTarget;
    public Transform rotateTarget;
    private float speed = 20f;

    public bool startDay = false;
    public float dayTimer = 0;
    public float dayLength = 0;

    void Update()
    {
        if (startDay)
        {
            Debug.Log("StartDay");
            Relocate();
            Spawner.SetActive(true);
            dayTimer += Time.deltaTime;
        }

        if(dayTimer >= dayLength)
        {
            if(manager.GovernmentTolerance > 0 && manager.Quota > 30)
            {
                
            }
        }
    }

    void Relocate()
    {
        mainCamera.transform.position = Vector3.MoveTowards(mainCamera.transform.position, camTarget.position, speed * Time.deltaTime);
        //mainCamera.transform.Rotate();
    }

}