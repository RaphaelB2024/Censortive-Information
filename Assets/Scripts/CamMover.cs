using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CamMover : MonoBehaviour
{
    public bool move = false;
    public float speed = 3f;
    public float rotateSpeed = 5f;
    public Transform camTarget;
    public Transform RotateTarget;

    void Update()
    {
        if (move)
        {
            Relocate();
        }
    }

    void Relocate()
    {
        transform.position = Vector3.MoveTowards(transform.position, camTarget.position, speed * Time.deltaTime);

        var rotation = Quaternion.LookRotation(RotateTarget.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotateSpeed);
    }
}
