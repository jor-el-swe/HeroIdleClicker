using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public ScriptableCharacter theHero;
  
    private int goldCarried;
    
    private int heroHealth;
    private int healthUpgradeCost;
    private float healthUpgradePercentage;

    private float attackPeriodTime;
    private int attackDamage;
    private float attackUpgradePercentage;
    private int attackUpgradeCost;
    
    // Start is called before the first frame update
    void Start()
    {
        goldCarried = theHero.goldCarried;
        
        heroHealth = theHero.characterHealth;
        healthUpgradeCost = theHero.healthUpgradeCost;
        healthUpgradePercentage = theHero.healthUpgradePercentage;
        
        attackPeriodTime = theHero.attackPeriodTime;
        attackDamage = theHero.attackDamage;
        attackUpgradeCost = theHero.attackUpgradeCost;
        attackUpgradePercentage = theHero.attackUpgradePercentage;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
