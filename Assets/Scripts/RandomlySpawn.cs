using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomlySpawn : MonoBehaviour
{
    public GameObject thingie;
    public float minHorizontal = -10.0f;
    public float maxHorizontal = 10.0f;
    public float minVertical = -10.0f;
    public float maxVertical = 10.0f;

    public float minSpwanTime = 1.0f;
    public float maxSpawnTime = 1.0f;

    void Start ()
	{
        Invoke("SpwanNow", Random.Range(minSpwanTime, maxSpawnTime));
	}

	void SpwanNow ()
	{
        Instantiate(thingie, transform.position + new Vector3(Random.Range(minHorizontal, maxHorizontal), Random.Range(minVertical, maxVertical)), Quaternion.identity);
        Invoke("SpwanNow", Random.Range(minSpwanTime, maxSpawnTime));
    }
}