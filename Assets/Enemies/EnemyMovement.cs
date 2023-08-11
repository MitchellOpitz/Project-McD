using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float detectionRadius = 10f;
    public float moveSpeed = 3f;

    private Transform player;
    private bool isPlayerInRange = false;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, detectionRadius);
    }

    private void Update()
    {
        // Calculate the distance between the enemy and the player
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        // Check if the player is within the detection radius
        if (distanceToPlayer <= detectionRadius)
        {
            isPlayerInRange = true;
        }
        else
        {
            isPlayerInRange = false;
        }

        // Handle enemy movement
        if (isPlayerInRange)
        {
            // Calculate the direction to the player
            Vector3 directionToPlayer = (player.position - transform.position).normalized;
            directionToPlayer.y = 0f; // Ensure movement is only in the XZ plane

            // Rotate the enemy to face the player
            transform.rotation = Quaternion.LookRotation(directionToPlayer);

            // Move the enemy towards the player
            transform.Translate(directionToPlayer * moveSpeed * Time.deltaTime);
        }
    }
}
