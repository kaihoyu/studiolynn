using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{

    [SerializeField] private Transform objectToMove;
    [SerializeField] private bool moveThisObject = false;
    [SerializeField] private float moveSpeed;
    [SerializeField] private List<Transform> points;
    private int counter;
    private bool goBack;
    public float StopTime;

    void Start()
    {
        counter = 0;
        goBack = false;
        if (moveThisObject)
        {
            objectToMove = transform;
        }
    }

    void Update()
    {
        if (counter == (points.Count - 1))
        {
            goBack = true;
        }
        else if (counter == 0)
        {
            goBack = false;
        }
        if (objectToMove.position == points[counter].position)
        {
            if (!goBack)
            {
                counter++;
            }
            else
            {
                counter--;
            }
        }
        objectToMove.position = Vector3.MoveTowards(objectToMove.position, points[counter].position, moveSpeed * Time.deltaTime);
    }
}