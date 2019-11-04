using System;
using UnityEngine;


[RequireComponent(typeof(NewCarController))]
public class NewCarAutoMove : MonoBehaviour
{
    private NewCarController m_Car; // the car controller we want to use
    public Transform goal;


    private void Awake()
    {
        // get the car controller
        m_Car = GetComponent<NewCarController>();
    }


    private void FixedUpdate()
    {
        var dir = goal.position - m_Car.transform.position;
        var dirH = Vector3.Project(dir, m_Car.transform.right);

        var v = 0f;
        if (dir.magnitude > 5f)
        {
            v = 3;
        }
        var h = 0f;

        if (Vector3.Angle(dir,m_Car.transform.forward)<15)
        {         
            v = 3;        
        }
        else
        {          
            Debug.Log(dirH);
            if ((m_Car.transform.right + dirH.normalized/2).magnitude > 1)
            {
                h = 3;
            }
            else
            {
                h = -3;
            }
            //h = -3;
        }

        var handbrake = 0f;
        //if(dir.magnitude < 2f)
        //{
        //    handbrake = 1;
        //}


        m_Car.Move(h,v,v,handbrake);

    }
}
