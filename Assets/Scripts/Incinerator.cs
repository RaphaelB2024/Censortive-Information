using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Incinerator : MonoBehaviour
{
    public bool incinerate;
    public AudioClip fire;

    private void OnTriggerStay(Collider collision)
    {
        if (incinerate)
        {
            soundManager.instance.PlayClip(fire, transform, 1f);
            Destroy(collision.gameObject);
        }
    }
}
