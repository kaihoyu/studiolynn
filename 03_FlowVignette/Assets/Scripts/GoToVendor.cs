using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GoToVendor : MonoBehaviour
{
    public GameObject[] vendor;
    public Transform final;
    private NavMeshAgent agent;
    private int destPoint = 0;
    private int i = 0;

    void Awake()
    {
        vendor = GameObject.FindGameObjectsWithTag("vendor");
    }

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.autoBraking = false;

        for (int positionOfArray = 0; positionOfArray < vendor.Length; positionOfArray++)
        {
            GameObject obj = vendor[positionOfArray];
            int randomizeArray = Random.Range(0, positionOfArray);
            vendor[positionOfArray] = vendor[randomizeArray];
            vendor[randomizeArray] = obj;
        }

        int i = Random.Range(0, vendor.Length);
        print(i);

        if (i == 0)
            GoToFinal();

        else
            GoToNextPoint();

    }

    void GoToNextPoint()
    {

        if (vendor.Length == 0)
            return;

        agent.destination = vendor[destPoint].transform.position;
        destPoint = (destPoint + 1) % i;

    }

    void GoToFinal()
    {
        agent.destination = final.position;
    }

    void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
        GoToNextPoint();

    }


}
