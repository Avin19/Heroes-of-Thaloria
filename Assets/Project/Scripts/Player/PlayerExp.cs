using System;
using UnityEngine;

/// <summary>
///  Handle player Experience 
/// </summary>

public class PlayerExp : MonoBehaviour
{
    [SerializeField] private PlayerStats stats;

    public void AddExperience(int amount)
    {
        stats.currentExp += amount;
        while (stats.currentExp > stats.nextLevelExp)
        {
            stats.currentExp -= stats.nextLevelExp;
            NextLevel();
        }
    }

    private void NextLevel()
    {
        stats.level++;
        float currentExpRequired = stats.nextLevelExp;
        float newNextLevelExp = Mathf.Round(currentExpRequired + stats.nextLevelExp * (stats.expMultipiler / 100f));
        stats.nextLevelExp = newNextLevelExp;
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            AddExperience(300);
        }
    }
}


