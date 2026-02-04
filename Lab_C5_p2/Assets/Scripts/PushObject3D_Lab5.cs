using UnityEngine;

public class PushObject3D : MonoBehaviour
{
    public float force = 10f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>()
                .AddForce(Vector3.forward * force, ForceMode.Impulse);
        }
    }
}
