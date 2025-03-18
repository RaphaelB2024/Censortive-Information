using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayManager : MonoBehaviour
{
    public GameObject mainCamera;

    void Start()
    {
        mainCamera.transform.position = new Vector3(0,-12, -6);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
