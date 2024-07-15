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

  public int health;
  public int maxHealth;


}


