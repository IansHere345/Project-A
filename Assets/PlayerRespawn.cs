using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{

public float threshold;

private Vector3 respawnPoint;
// This is a private variable that changes based on what tags the player runs into

public static int deathCount = 0;
// Tracks the death counter

    void Start()
    {
        respawnPoint = new Vector3(0.0f, 50.95f, 4.0f);
        // Default starting position
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if(transform.position.y < threshold)
        {
            transform.position = respawnPoint;
            deathCount++;
            // Death count increases by 1
        }
        // If the player is detetcted below the y axis threshold (which is -30), they will respawn at Vector3
        //Source Used: https://www.youtube.com/watch?v=Mic9ERhr0HA&t=103s
    }
    private void OnTriggerEnter(Collider other)
    {
    if(other.gameObject.CompareTag("Checkpoint1")) // Player Interacts with a different tag
        {
            respawnPoint = new Vector3(297.0f, 70.00f, 225.3f);
            // Changes respawn Point
        }
    if (other.gameObject.CompareTag("Checkpoint2")) // Player Interacts with a different tag
        {
            respawnPoint = new Vector3(385.7f, 143.00f, -92.3f);
            // Changes respawn Point
        }
    if (other.gameObject.CompareTag("Checkpoint3")) // Player Interacts with a different tag
        {
            respawnPoint = new Vector3(283.0f, 140.00f, -50.7f);
            // Changes respawn Point
        }
    }
}
