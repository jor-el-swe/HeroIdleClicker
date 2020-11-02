using UnityEngine;

public class Hero : MonoBehaviour
{
    public ScriptableCharacter theHero;
  
    private int _goldCarried;
    
    private int _heroHealth;
    private int _healthUpgradeCost;
    private float _healthUpgradePercentage;

    private float _attackPeriodTime;
    private int _attackDamage;
    private float _attackUpgradePercentage;
    private int _attackUpgradeCost;

    private float _attackTimer;
    
    // Start is called before the first frame update
    void Start()
    {
        _goldCarried = theHero.goldCarried;
        
        _heroHealth = theHero.characterHealth;
        _healthUpgradeCost = theHero.healthUpgradeCost;
        _healthUpgradePercentage = theHero.healthUpgradePercentage;
        
        _attackPeriodTime = theHero.attackPeriodTime;
        _attackDamage = theHero.attackDamage;
        _attackUpgradeCost = theHero.attackUpgradeCost;
        _attackUpgradePercentage = theHero.attackUpgradePercentage;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
