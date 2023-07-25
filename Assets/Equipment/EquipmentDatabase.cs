using UnityEngine;

[CreateAssetMenu(fileName = "New Equipment Database", menuName = "Equipment/Equipment Database")]
public class EquipmentDatabase : ScriptableObject
{
    public Equipment[] equipmentItems;
}