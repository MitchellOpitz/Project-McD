using UnityEngine;

public class Inventory : MonoBehaviour
{
    public EquipmentDatabase equipmentDatabase;
    public int maxInventorySlots = 10;

    private Equipment[] inventoryItems;

    private void Start()
    {
        // Initialize the inventory array
        inventoryItems = new Equipment[maxInventorySlots];

        //Test();
    }

    public void Test()
    {
        // Adding to Inventory
        for (int i = 0; i < 5; i++)
        {
            AddToInventory(equipmentDatabase.equipmentItems[Random.Range(0, equipmentDatabase.equipmentItems.Length)]);
        }
        PrintInventory();

        for (int i = 0; i < 5; i++)
        {
            RemoveFromInventory(equipmentDatabase.equipmentItems[Random.Range(0, equipmentDatabase.equipmentItems.Length)]);
        }
        PrintInventory();
    }

    public void AddToInventory(Equipment equipment)
    {
        // Check if the inventory is already full
        if (IsInventoryFull())
        {
            Debug.Log("Inventory is full!");
            return;
        }

        // Add the equipment to the first available inventory slot
        for (int i = 0; i < inventoryItems.Length; i++)
        {
            if (inventoryItems[i] == null)
            {
                inventoryItems[i] = equipment;
                Debug.Log("Added " + equipment.equipmentName + " to inventory.");
                return;
            }
        }
    }

    public void RemoveFromInventory(Equipment equipment)
    {
        // Remove the equipment from the inventory
        for (int i = 0; i < inventoryItems.Length; i++)
        {
            if (inventoryItems[i] == equipment)
            {
                inventoryItems[i] = null;
                Debug.Log("Removed " + equipment.equipmentName + " from inventory.");
                return;
            }
        }
    }

    public bool IsInventoryFull()
    {
        // Check if the inventory is full
        for (int i = 0; i < inventoryItems.Length; i++)
        {
            if (inventoryItems[i] == null)
            {
                return false;
            }
        }
        return true;
    }

    // Example method to demonstrate accessing equipment data from the inventory
    public void PrintInventory()
    {
        for (int i = 0; i < inventoryItems.Length; i++)
        {
            if (inventoryItems[i] != null)
            {
                Debug.Log("Slot " + i + ": " + inventoryItems[i].equipmentName);
            }
        }
    }
}