using System;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public ScriptableCharacter scriptedEnemy;

    private Enemy _enemy;
    // Start is called before the first frame update
    void Start()
    {
        _enemy = new Enemy
        {
            GoldCarried = scriptedEnemy.goldCarried,
            EnemyHealth = scriptedEnemy.characterHealth,
            AttackPeriodTime = scriptedEnemy.attackPeriodTime,
            AttackDamage = scriptedEnemy.attackDamage
        };

    }

    // Update is called once per frame
    void Update()
    {
        
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
}
