using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtons : MonoBehaviour
{
 void nextDay(int index)
    {
        SceneManager.LoadScene(index);
    }
}
