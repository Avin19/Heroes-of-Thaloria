using System;
using UnityEngine;

/// <summary>
///  Basic Player Class that will communicate with other class that are not related to player 
/// </summary>

public class Player : MonoBehaviour
{
    [SerializeField] private PlayerStats _stats;
    private PlayerAnimation _animation;
    public PlayerStats Stats => _stats;

    private void Awake()
    {
        _animation = GetComponent<PlayerAnimation>();
    }

    public void RevivePlayer()
    {
        _animation.SetPlayerRevive();
        _stats.Reset();
    }
}


