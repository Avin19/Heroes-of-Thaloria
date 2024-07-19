using System;
using UnityEngine;

/// <summary>
///  
/// </summary>

public class EnemyBrain : MonoBehaviour
{
  public FSMState CurrentState { get; set; }
  [SerializeField] private string initState;
  [SerializeField] private FSMState[] states;
  private void Update()
  {
    CurrentState.UpdateState(this);
  }

  public void ChangeState(string newStateID)
  {
    
  }

  private FSMState GetState(string newStateID)
  {
    for (int i = 0; i< states.Length; i++)
    {
      if (states[i].ID == newStateID)
      {
        
      }
    }
  }
}


