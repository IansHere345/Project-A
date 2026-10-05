using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public float jumpForce; // The force applied to the player when they hit the jump pad

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddForce(transform.up * jumpForce);
            }
        }
    }
}
