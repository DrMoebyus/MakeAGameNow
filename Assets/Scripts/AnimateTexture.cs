using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateTexture : MonoBehaviour
{
    public Vector2 speed = Vector2.one;

	void Start ()
    {
		
	}
	
	void Update ()
    {
        GetComponent<Renderer>().material.mainTextureOffset += speed * Time.deltaTime;
    }
}
