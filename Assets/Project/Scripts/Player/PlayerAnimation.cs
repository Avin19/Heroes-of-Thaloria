using System;
using UnityEngine;

/// <summary>
///  Control the Player Animation 
/// </summary>

public class PlayerAnimation : MonoBehaviour
{
  private Animator _animator;
  private readonly int moveX = Animator.StringToHash("MoveX");
  private readonly int moveY = Animator.StringToHash("MoveY");
  private readonly int moving = Animator.StringToHash("Moving");
  private readonly int dead = Animator.StringToHash("Dead");
  private readonly int revive = Animator.StringToHash("Revive");
  private void Awake()
  {
    _animator = GetComponent<Animator>();
  }

  public void SetIdleAnimation(bool value)
  {
    _animator.SetBool(moving, value);
  }

  public void SetMoveAnimation(Vector2 dir)
  {
    _animator.SetFloat(moveX, dir.x);
    _animator.SetFloat(moveY , dir.y);
  }

  public void SetDeadAnimation()
  {
    _animator.SetTrigger(dead);
  }

  public void SetPlayerRevive()
  {
    SetMoveAnimation(Vector2.down);
    _animator.SetTrigger(revive);
  }
}




