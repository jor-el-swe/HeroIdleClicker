using UnityEngine;

public class Hero : MonoBehaviour
{
    public ScriptableCharacter theHero;

    public bool IsDead { get; private set; } = false;

    private int _goldCarried;
    private int _heroHealth;
    
    private float _attackPeriodTime;
    private int _attackDamage;


    private float _attackTimer;

    private EnemyHandler _enemyHandler;
    
    // Start is called before the first frame update
    void Start()
    {
        _goldCarried = theHero.goldCarried;
        
        _heroHealth = theHero.characterHealth;
        
        _attackPeriodTime = theHero.attackPeriodTime;
        _attackDamage = theHero.attackDamage;

        _enemyHandler = FindObjectOfType<EnemyHandler>();

    }

    // Update is called once per frame
    void Update()
    {
        if (IsDead) return;
        
        _attackTimer += Time.deltaTime;

        if (_attackTimer >= _attackPeriodTime)
        {
            _attackTimer -= _attackPeriodTime;
            Attack();
        }
    }

    private void Attack()
    {
        Debug.Log($"hero attacks! dmg:{_attackDamage} health: {_heroHealth}");
        if(_enemyHandler.TakeDamage(_attackDamage, ref _goldCarried))
        {
            Debug.Log("killed enemy!");
            Debug.Log($"hero gold: {_goldCarried}");
        }
    }

    public void TakeDamage(int enemyAttackDamage)
    {
        _heroHealth -= enemyAttackDamage;
        IsDead = _heroHealth <= 0;
        Debug.Log($"hero health: {_heroHealth}");
        if(IsDead) Debug.Log("hero died!");
    }
}
