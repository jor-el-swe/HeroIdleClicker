using UnityEngine;

[CreateAssetMenu(menuName = "RPGIdleClicker/Character")]
public class ScriptableCharacter : ScriptableObject
{
    public float attackPeriodTime;
    public int attackDamage;
    public int characterHealth;
    public int goldCarried;
    public int healthUpgradeCost = 50;
    public float healthUpgradePercentage = 0.1f;
    public int attackUpgradeCost = 50;
    public float attackUpgradePercentage = 0.1f;
}
