using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Vector3 direction = Vector3.forward;
    public float speed = 1.0f;

	void Update ()
    {
        transform.position += transform.rotation*(direction.normalized*speed*Time.deltaTime);
    }
}