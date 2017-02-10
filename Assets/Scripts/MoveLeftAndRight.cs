using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftAndRight : MonoBehaviour
{
    public float speed = 1.0f;

    void Update()
    {
            //This moves our object left or right based on input
            transform.position += Vector3.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime;
    }
}