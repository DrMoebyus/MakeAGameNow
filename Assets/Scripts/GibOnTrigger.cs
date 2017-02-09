using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GibOnTrigger : MonoBehaviour
{
    public GameObject gib;

    void OnTriggerEnter ()
    {
        Instantiate(gib, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
