using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Incinerator : MonoBehaviour
{
    public bool incinerate;

    private void OnTriggerStay(Collider collision)
    {
        if (incinerate)
        {
            Destroy(collision.gameObject);
        }
    }
}
