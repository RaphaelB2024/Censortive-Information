using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteClick : MonoBehaviour
{
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
