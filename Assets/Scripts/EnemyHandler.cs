using System;
using UnityEngine;

public class EnemyHandler : MonoBehaviour
{
    public ScriptableCharacter scriptedEnemy;

    private Enemy _enemy;
    private float _attackTimer;
    private Hero _hero;
    void Start()
    {
        _enemy = new Enemy
        {
            GoldCarried = scriptedEnemy.goldCarried,
            EnemyHealth = scriptedEnemy.characterHealth,
            AttackPeriodTime = scriptedEnemy.attackPeriodTime,
            AttackDamage = scriptedEnemy.attackDamage
        };

        _hero = FindObjectOfType<Hero>();

    }

    // Update is called once per frame
    void Update()
    {
        _attackTimer += Time.deltaTime;

        if (_attackTimer >= _enemy.AttackPeriodTime)
        {
            Attack();
            _attackTimer -= _enemy.AttackPeriodTime;
        }
    }

    private void Attack()
    {
        if (_hero.IsDead) return;
        Debug.Log($"enemy attacks! dmg:{_enemy.AttackDamage} health: {_enemy.EnemyHealth}");
        _hero.TakeDamage(_enemy.AttackDamage);
    }

    private void FixedUpdate()
    {
        if (_enemy.EnemyHealth <= 0)
        {
            //do some fancy dying stuff
            
            
            //spawn new enemy
            Debug.Log("new enemy spawned");
            _enemy.EnemyHealth = scriptedEnemy.characterHealth;
        }
    }

    public bool TakeDamage(int attackDamage, ref int goldCarried)
    {
        _enemy.EnemyHealth -= attackDamage;
        if (_enemy.EnemyHealth <= 0)
        {
            goldCarried += _enemy.GoldCarried;
            return true;
        }
        
        return false;
    }
}
