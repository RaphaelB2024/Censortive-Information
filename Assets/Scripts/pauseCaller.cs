using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class pauseCaller : MonoBehaviour
{
    [SerializeField] private GameObject pauseScreen;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(pauseScreen.activeSelf == true)
            {
                pauseScreen.SetActive(false); 
            }

            else
            {
                pauseScreen.SetActive(true);
            }
        }
    }
}
