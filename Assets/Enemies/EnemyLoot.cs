using UnityEngine;

public class EnemyLoot : MonoBehaviour
{
    public LootTable lootTable;

    public void RollForLoot()
    {
        // Check if the enemy has a valid loot table
        if (lootTable != null)
        {
            // Loop through each entry in the loot table
            foreach (LootTable.LootEntry lootEntry in lootTable.lootEntries)
            {
                // Check if the random number (0-1) is less than the drop chance
                if (Random.value * 100 < lootEntry.dropChance)
                {
                    Debug.Log("Dropped: " + lootEntry.item.equipmentName + ".");
                    return;
                    // Instantiate the dropped item at the enemy's position
                    //Instantiate(lootEntry.item, transform.position, Quaternion.identity);
                }
            }
        }
    }
}