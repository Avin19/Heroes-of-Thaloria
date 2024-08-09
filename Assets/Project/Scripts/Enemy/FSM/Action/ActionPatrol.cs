using UnityEngine;



public class ActionPatrol : FSMAction
{
  [Header("Config")]
  [SerializeField] private float speed;

  private Waypoints _wayPoints;
  private int pointIndex;
  private Vector3 nextPostion;

  private void Awake()
  {
    _wayPoints = transform.GetComponent<Waypoints>();
  }
  public override void Act()
  {
    FollowPath();
  }

  private void FollowPath()
  {
    transform.position = Vector3.MoveTowards(transform.position, GetCurrentPosition(), speed * Time.deltaTime);
    if (Vector3.Distance(transform.position, GetCurrentPosition()) <= 0.1f)
    {
      UpdateNextPosition();
    }
  }

  private void UpdateNextPosition()
  {
    pointIndex++;
    if (pointIndex > _wayPoints.Points.Length - 1)
    {
      pointIndex = 0;
    }
  }
  private Vector3 GetCurrentPosition()
  {
    return _wayPoints.GetPostion(pointIndex);
  }


}


