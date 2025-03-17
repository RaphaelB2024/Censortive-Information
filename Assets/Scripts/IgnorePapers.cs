using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnorePapers : MonoBehaviour
{
    void Start()
    {
        Physics.IgnoreLayerCollision(6,6);
        //Collision between two layers is ignored
        //In this example, Layer 6 & 6 are ignoring each other
    }
}

