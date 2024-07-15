using System;
using UnityEngine;

/// <summary>
///  Player Movement 
/// </summary>

  public class PlayerMovemnt : MonoBehaviour
  {
    [Header("Config")] [SerializeField] private float _moveSpeed;

    private GameInput _gameInput;
    private Rigidbody2D _rb;
    private Vector2 _moveDir;
    private PlayerAnimation animationController;
    private Player player;
  

    private void Awake()
    {
      _gameInput = new GameInput();
      _rb = GetComponent<Rigidbody2D>();
      animationController.GetComponent<PlayerAnimation>();
      player = GetComponent<Player>();


    }

    private void FixedUpdate()
    {
      ReadMovement();
      Move();
    }

    private void Move()
    {
      if (player.Stats.health <= 0) return;
      _rb.MovePosition(_rb.position + _moveDir * (_moveSpeed * Time.deltaTime));
    }

    private void ReadMovement()
    {
      _moveDir = _gameInput.Player.Move.ReadValue<Vector2>();
      if (_moveDir == Vector2.zero)
      {
        animationController.SetIdleAnimation(false);
        return;
      }
      animationController.SetIdleAnimation(true);
      animationController.SetMoveAnimation(_moveDir);
    }



    private void OnEnable()
    {
      _gameInput.Enable();
    }

    private void OnDisable()
    {
      _gameInput.Disable();
    }
  }


