using UnityEngine;

/// <summary>
///  Player Mana Manager
/// </summary>

public class PlayerMana : MonoBehaviour
{
  [SerializeField] private PlayerStats state;

  private void UseMana(float amount)
  {
    if (state.mana >= amount)
    {
      state.mana = Mathf.Max(state.mana -= amount, 0f);
      
    }
  }

}


