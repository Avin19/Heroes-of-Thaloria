using System;
using UnityEngine;



public class WayPoint : MonoBehaviour
{
    [Header("Config")]
    [SerializeField] private Vector3[] points;

    public Vector3[] Points => points;
    public Vector3 EntityPostion { get; set; }
    private bool gameStarted;
    private void Start()
    {
        EntityPostion = transform.position;
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


