using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneWayPlatform : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb != null && rb.velocity.y < 0)
        {
            Collider platformCollider = GetComponent<Collider>();
            Physics.IgnoreCollision(other, platformCollider, true);
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        Collider platformCollider = GetComponent<Collider>();
        Physics.IgnoreCollision(other, platformCollider, false);
    }
}
