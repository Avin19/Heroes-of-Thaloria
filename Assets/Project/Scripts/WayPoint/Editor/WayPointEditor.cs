using System;
using UnityEditor;
using UnityEngine;


[CustomEditor(typeof(WayPoint))]
public class WayPointEditor : Editor
{
  private WayPoint _wayPointTarget => target as WayPoint;


  private void OnSceneGUI()
  {
    if(_wayPointTarget.Points.Length <= 0) return;
    Handles.color = Color.red;

    for (int i = 0; i < _wayPointTarget.Points.Length; i++)
    {
      EditorGUI.BeginChangeCheck();
      Vector3 currentPoint = _wayPointTarget.EntityPostion + _wayPointTarget.Points[i];
      Vector3 newPosition = Handles.FreeMoveHandle(currentPoint, 0.5f, Vector3.one*0.5f, Handles.SphereHandleCap);


      GUIStyle text = new GUIStyle();
      text.fontStyle = FontStyle.Bold;
      text.fontSize = 16;
      text.normal.textColor = Color.black;
      Vector3 textPos = new Vector3(0.2f, -0.2f);
      Handles.Label(_wayPointTarget.EntityPostion + _wayPointTarget.Points[i]+textPos,$"{i+1}", text);

      if (EditorGUI.EndChangeCheck())
      {
        Undo.RecordObject(target, "Free Move");
        _wayPointTarget.Points[i] = newPosition - _wayPointTarget.EntityPostion;
        
      }
    }
  }
}


