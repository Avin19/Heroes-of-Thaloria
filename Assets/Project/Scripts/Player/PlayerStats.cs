using System;
using UnityEngine;
using UnityEngine.Serialization;

/// <summary>
///  
/// </summary>

[CreateAssetMenu(fileName = "" , menuName ="")]
public class PlayerStats : ScriptableObject
{
  [Header(" Config")]
  public int level;
  [Header(" Health ")]
  public float health;
  public float maxHealth;
  [Header(" Mana")] 
  public float mana;
  public float maxMana;

  [Header("Exp")] public float currentExp;
  public float nextLevelExp;
  public float initialNextLevelExp;
  [Range(1f, 100f)] public int expMultipiler;


  public void Reset()
  {
    health = maxHealth;
    mana = maxMana;
    level = 1;
    currentExp = 0f;
    nextLevelExp = initialNextLevelExp;
  }
}


