using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;
    private bool isDead = false;
    private EnemyLoot enemyLoot;

    private void Start()
    {
        currentHealth = maxHealth;
        enemyLoot = GetComponent<EnemyLoot>();
    }

    public void TakeDamage(int damage)
    {
        if (!isDead)
        {
            Debug.Log("Enemy takes " + damage + " damage.");
            currentHealth -= damage;
            if (currentHealth <= 0)
            {
                Die();
            }
        }
    }

    private void Die()
    {
        Debug.Log("Enemy has died.");
        isDead = true;
        if (enemyLoot.lootTable != null)
        {
            enemyLoot.RollForLoot();
        }
        Destroy(gameObject);
    }
}