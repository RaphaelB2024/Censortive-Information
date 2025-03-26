using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtons : MonoBehaviour
{
    public GameObject subjectCanvas;

 public void nextDay(int index)
    {
        SceneManager.LoadScene(index + 1);
    }

    public void destroyCanvas()
    {
        Destroy(subjectCanvas);
    }
}
