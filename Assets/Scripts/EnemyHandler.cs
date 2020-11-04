using UnityEngine;

public class EnemyHandler : MonoBehaviour
{
    public ScriptableCharacter scriptedEnemy;

    private float _enemyHealth;
    private float _attackTimer;
    private Hero _hero;
    void Start()
    {
        _enemyHealth = scriptedEnemy.characterHealth;
        _hero = FindObjectOfType<Hero>();

    }

    // Update is called once per frame
    void Update()
    {
        _attackTimer += Time.deltaTime;

        if (_attackTimer >= scriptedEnemy.attackPeriodTime)
        {
            Attack();
            _attackTimer -= scriptedEnemy.attackPeriodTime;
        }
    }

    private void Attack()
    {
        if (_hero.IsDead) return;
        Debug.Log($"enemy attacks! dmg:{scriptedEnemy.attackDamage} health: {_enemyHealth}");
        _hero.TakeDamage(scriptedEnemy.attackDamage);
    }

    private void FixedUpdate()
    {
        if (_enemyHealth <= 0)
        {
            //do some fancy dying stuff
            
            
            //spawn new enemy
            Debug.Log("new enemy spawned");
            _enemyHealth = scriptedEnemy.characterHealth;
        }
    }

    public bool TakeDamage(int attackDamage, ref int goldCarried)
    {
        _enemyHealth -= attackDamage;
        if (_enemyHealth <= 0)
        {
            goldCarried += scriptedEnemy.goldCarried;
            return true;
        }
        
        return false;
    }
}
