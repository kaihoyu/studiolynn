using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class PathFollow : MonoBehaviour
{
    public PathCreator pathCreator;
    public float speed = 2.0f;
    public float yOffset = -1.0f;
    float distanceTravelled;

    void Update()
    {
        distanceTravelled += speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled) + Vector3.up * yOffset;
    }
}
