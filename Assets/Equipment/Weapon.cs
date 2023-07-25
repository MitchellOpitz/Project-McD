using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Equipment/Weapon")]
public class Weapon : Equipment
{
    public int attackPower;
    public float attackSpeed;
    public DamageType damageType;
}