using UnityEngine;

[CreateAssetMenu(fileName = "New Equipment", menuName = "Equipment")]
public class Equipment: ScriptableObject
{
    public string equipmentName;
    public string description;
    public Rarity rarity;
    public GameObject prefab;
}