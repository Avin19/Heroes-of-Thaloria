using UnityEngine;



public class ActionPatrol: FSMAction
{
  [Header("Config")] 
  [SerializeField] private float speed;

  private WayPoint _wayPoint;
  private int pointIndex;
  private Vector3 nextPostion;

  private void Awake()
  {
    _wayPoint = GetComponent<WayPoint>();
  }
  public override void Act()
  {
    
  }

  private void FollowPath()
  {
    transform.postion = Vector3.MoveTowards();
  }
  private Vector3 GetCurrentPosition()
  {

    return _wayPoint.GetPosition(pointIndex);
  }

}


