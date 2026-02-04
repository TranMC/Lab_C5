using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conveyor : MonoBehaviour
{
    public float speed = 5f;
    public Vector3 direction = Vector3.right;
    
    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<Rigidbody>())
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb != null)
            {
                Vector3 conveyorVelocity = direction.normalized * speed;
                rb.velocity = new Vector3(conveyorVelocity.x, rb.velocity.y, conveyorVelocity.z);
            }
        }
    }
}
