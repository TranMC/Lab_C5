using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectTrigger_Lab6 : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision với: " + collision.gameObject.name);
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Va chạm với: " + other.gameObject.name);
    }
}
