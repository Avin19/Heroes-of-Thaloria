using System;
using UnityEngine;

/// <summary>
///  Player Health Controller 
/// </summary>

public class PlayerHealth : MonoBehaviour ,IDamagable
{
  [SerializeField] private PlayerStats _stats;
  private PlayerAnimation _playerAnimation;

  private void Awake()
  {
    _playerAnimation.GetComponent<PlayerAnimation>();
  }


  public void TakeDamage(int amount)
  {
    _stats.health -= amount;

    if (_stats.health <= 0)
    {
      PlayerDead();
    }
  }

  private void PlayerDead()
  {
    _playerAnimation.SetDeadAnimation();
  }
  
}


