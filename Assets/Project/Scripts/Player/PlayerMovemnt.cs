using System;
using UnityEngine;

/// <summary>
///  
/// </summary>

public class PlayerMovemnt : MonoBehaviour
{
  [Header("Config")]
  [SerializeField] private float moveSpeed;

  private GameInput _gameInput;
  private Rigidbody2D _rb;
  private Vector2 _moveDir;

  private void Awake()
  {
    _gameInput = new GameInput();
    _rb = GetComponent<Rigidbody2D>();
    

  }
}


