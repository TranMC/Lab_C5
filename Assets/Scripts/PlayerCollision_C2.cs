using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_C1 : MonoBehaviour
{
 // Phát hiện va chạm với Collider thường
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision với: " + collision.gameObject.name);
    }

    // Phát hiện khi thoát va chạm
    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Thoát collision với: " + collision.gameObject.name);
    }

    // Phát hiện trigger (cần IsTrigger = true)
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger với: " + other.gameObject.name);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("Thoát trigger với: " + other.gameObject.name);
    }
}
