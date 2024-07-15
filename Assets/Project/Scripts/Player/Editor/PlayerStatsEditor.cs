using UnityEngine;
using UnityEditor;
/// <summary>
///  
/// </summary>

[CustomEditor(typeof(PlayerStats))]
public class PlayerStatsEditor :Editor
{
    private PlayerStats targetSate => target as PlayerStats;

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if (GUILayout.Button("Reset Player"))
        {
            targetSate.Reset();
        }
    }

}


