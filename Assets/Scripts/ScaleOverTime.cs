﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleOverTime : MonoBehaviour
{
    public Vector3 finalScale = Vector3.zero;
    public float time = 1.0f;

    private Vector3 initialScale;

	void Start ()
	{
        initialScale = transform.localScale;
        StartCoroutine("Scale");
	}

	IEnumerator Scale ()
	{
        float t = 0.0f;

        while (t <= time)
        {
            transform.localScale = Vector3.Lerp(initialScale, finalScale, t / time);
            t += Time.deltaTime;
            yield return null;
        }

        transform.localScale = finalScale;
	}
}