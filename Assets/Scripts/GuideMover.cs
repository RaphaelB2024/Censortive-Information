using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guideMover : MonoBehaviour
{
    public bool move = false;
    public float speed = 3f;
    public float rotateSpeed = 5f;
    public Transform moveTarget;
    public Transform rotateTarget;

    private void OnMouseDown()
    {
        move = true;
    }

    private void Update()
    {
        if (move)
        {
            Relocate();
        }
    }
    void Relocate()
    {
        transform.position = Vector3.MoveTowards(transform.position, moveTarget.position, speed * Time.deltaTime);

        var rotation = Quaternion.LookRotation(rotateTarget.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotateSpeed);
    }
}
