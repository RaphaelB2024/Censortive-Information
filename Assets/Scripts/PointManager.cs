using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointManager : MonoBehaviour
{
    public int GovernmentTolerance = 10;
    public int Quota = 0;
    public int quotaTarget = 20;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
}
