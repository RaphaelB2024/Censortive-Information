using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.GraphicsBuffer;

public class DayManager : MonoBehaviour
{
    public PointManager manager;

    public GameObject mainCamera;
    public GameObject camTarget;
    public Transform rotateTarget;
    private float speed = 0.5f;

    public bool startDay = false;
    public float dayTimer = 0;
    public float dayLength = 0;

    void Update()
    {
        if (startDay)
        {
            Debug.Log("StartDay");
            Vector3 direction = rotateTarget.position - camTarget.transform.position;
            Quaternion rotation = Quaternion.LookRotation(direction);
            transform.rotation = rotation;
            dayTimer += Time.deltaTime;
        }

        if(dayTimer >= dayLength)
        {
            if(manager.GovernmentTolerance > 0 && manager.Quota > 30)
            {
                
            }
        }
    }


}