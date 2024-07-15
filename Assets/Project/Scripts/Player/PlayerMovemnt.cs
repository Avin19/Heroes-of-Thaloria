using System;
using UnityEngine;

/// <summary>
///  Player Movement 
/// </summary>
namespace Player.Movement
{

  public class PlayerMovemnt : MonoBehaviour
  {
    [Header("Config")] [SerializeField] private float _moveSpeed;

    private GameInput _gameInput;
    private Rigidbody2D _rb;
    private Vector2 _moveDir;
    private Animator _animator;

    private readonly int moveX = Animator.StringToHash("MoveX");
    private readonly int moveY = Animator.StringToHash("MoveY");

    private void Awake()
    {
      _gameInput = new GameInput();
      _rb = GetComponent<Rigidbody2D>();
      _animator = GetComponent<Animator>();

    }

    private void FixedUpdate()
    {
      ReadMovement();
      Move();
    }

    private void Move()
    {
      _rb.MovePosition(_rb.position + _moveDir * (_moveSpeed * Time.deltaTime));
    }

    private void ReadMovement()
    {
      _moveDir = _gameInput.Player.Move.ReadValue<Vector2>();
      if(_moveDir == Vector2.zero) return;
      _animator.SetFloat(moveX,_moveDir.x);
      _animator.SetFloat(moveY , _moveDir.y);
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
}


