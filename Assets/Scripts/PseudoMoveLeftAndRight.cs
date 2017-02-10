using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PseudoMoveLeftAndRight : MonoBehaviour
{
    public float speed = 1.0f;

	void Update ()
	{
        GetComponent<Renderer>().material.mainTextureOffset += Vector2.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime;
    }
}