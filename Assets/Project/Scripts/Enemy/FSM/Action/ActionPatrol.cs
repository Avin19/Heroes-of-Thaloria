using UnityEngine;



public class ActionPatrol: FSMAction
{
  [Header("Config")] 
  [SerializeField] private float speed;

  private WayPoint _wayPoint;
  private int pointIndex;

  private void Awake()
  {
    _wayPoint = GetComponent<WayPoint>();
  }
  public override void Act()
  {
    
  }

}


~