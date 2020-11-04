using UnityEngine;

[CreateAssetMenu(menuName = "RPGIdleClicker/Character")]
public class ScriptableCharacter : ScriptableObject
{
    public float attackPeriodTime;
    public int attackDamage;
    public int characterHealth;
    public int goldCarried;
    public int healthUpgradeCost;
    public float healthUpgradePercentage;
    public int attackUpgradeCost;
    public float attackUpgradePercentage;
}
