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
  public int health;
  public int maxHealth;
  [Header(" Mana")] public float mana;
  public float maxMana;


  public void Reset()
  {
    health = maxHealth;
    mana = maxMana;
  }
}


