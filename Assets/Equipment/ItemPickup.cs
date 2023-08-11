using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Equipment equipmentItem; // Reference to the Equipment scriptable object
    public float pickupRadius = 2f; // The radius within which the item can be picked up

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) // Change to your desired button
        {
            TryPickupItem();
        }
    }

    private void TryPickupItem()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, pickupRadius);
        foreach (Collider collider in colliders)
        {
            if (collider.CompareTag("Player"))
            {
                Inventory inventory = collider.GetComponent<Inventory>();
                if (inventory != null)
                {
                    inventory.AddToInventory(equipmentItem);
                    Destroy(gameObject); // Remove the item from the scene
                }
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, pickupRadius);
    }
}
