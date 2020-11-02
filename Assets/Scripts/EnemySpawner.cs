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
            goldCarried = scriptedEnemy.goldCarried,
            enemyHealth = scriptedEnemy.characterHealth,
            attackPeriodTime = scriptedEnemy.attackPeriodTime,
            attackDamage = scriptedEnemy.attackDamage
        };

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
