using UnityEngine;


/// <summary>
///  Game Manager for testing only may be used as singleton in future
/// 
/// </summary>

public class GameManager : MonoBehaviour
{
    [SerializeField] private Player player;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            player.RevivePlayer();
        }
    }
}


