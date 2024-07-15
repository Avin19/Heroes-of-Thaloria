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

    private void Awake()
    {
      _gameInput = new GameInput();
      _rb = GetComponent<Rigidbody2D>();

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


