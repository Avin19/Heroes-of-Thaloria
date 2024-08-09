using UnityEngine;



public class Waypoints : MonoBehaviour
{
    [Header("Config")]
    [SerializeField] private Vector3[] points;

    public Vector3[] Points => points;
    public Vector3 EntityPostion { get; set; }
    private bool gameStarted;
    private void Start()
    {
        EntityPostion = transform.position;
        gameStarted = true;
    }

    public Vector3 GetPostion(int pointIndex)
    {
        return EntityPostion + points[pointIndex];
    }
    private void OnDrawGizmos()
    {
        if (gameStarted == false && transform.hasChanged)
        {
            EntityPostion = transform.position;
        }
    }
}


