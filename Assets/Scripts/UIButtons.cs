using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtons : MonoBehaviour
{
    public GameObject menu;
    public GameObject credit;

 public void begin()
    {
        SceneManager.LoadScene("Day 1");
    }

    public void credits()
    {
        menu.SetActive(false);
        credit.SetActive(true);
    }

    public void backtomenu()
    {
        credit.SetActive(false);
        menu.SetActive(true);
    }

    public void quit()
    {
        Application.Quit();
    }
}
