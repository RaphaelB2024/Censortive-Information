using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIFade : MonoBehaviour
{
    public float speed = 5;
    public void Fade()
    {
        StartCoroutine(startFade());
    }

    IEnumerator startFade()
    {
        CanvasGroup canvasGroup = GetComponent<CanvasGroup>();
        while (canvasGroup.alpha < 1)
        {
            canvasGroup.alpha += Time.deltaTime / speed;
            yield return null;
        }
        canvasGroup.interactable = false;
        yield return null;
    }
}
