using UnityEngine;

[CreateAssetMenu(fileName = "New Loot Table", menuName = "Loot Table")]

public class LootTable : ScriptableObject
{
    [System.Serializable]
    public class LootEntry
    {
        public Equipment item;
        public float dropChance;
    }

    public LootEntry[] lootEntries;
}