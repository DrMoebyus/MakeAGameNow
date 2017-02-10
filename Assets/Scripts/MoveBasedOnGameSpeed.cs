using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBasedOnGameSpeed : MonoBehaviour
{
    public Vector3 direction = Vector3.forward;

	void Update ()
    {
        transform.position += transform.rotation*(direction.normalized*GameManager.Instance.gameSpeed*Time.deltaTime);
    }
}
