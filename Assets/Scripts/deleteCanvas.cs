using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteCanvas : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Destroy(gameObject);
        }
    }
}
