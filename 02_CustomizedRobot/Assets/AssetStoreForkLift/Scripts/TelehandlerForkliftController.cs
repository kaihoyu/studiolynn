using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelehandlerForkliftController : MonoBehaviour {

    public Transform Arrow1;
    public Transform Arrow2;
    public Transform detail1;
    public float maxAngleArr;
    public float minAngleArr;
    public float maxAngleDet;
    public float minAngleDet;
    // private Quaternion startRotDet;
    //  private Quaternion startRotArr;
    private Vector3 startRotDet;
    private Quaternion startRotArr;

    private bool startRotDetailBool;
    public float ArrowSpeed;
    public float Arrow2SpeedForward;
    public float DetailSpeed;

    public Vector3 forwardPos;
    public Vector3 rearPos;

    // Use this for initialization
    void Awake () {
        startRotDet = detail1.localEulerAngles;
        startRotArr = Arrow1.transform.rotation;
    }

    // Update is called once per frame
    void FixedUpdate()
    {


        if (Input.GetKey(KeyCode.PageUp))
        {
            Quaternion target = Quaternion.Euler(0 + maxAngleArr, 0, 0);
            Quaternion target1 = Quaternion.Euler(0 - maxAngleDet, 0, 0);

            Arrow1.transform.localRotation = Quaternion.RotateTowards(Arrow1.transform.localRotation, target, Time.deltaTime * ArrowSpeed);

            startRotDet.x = startRotDet.x + ArrowSpeed * Time.deltaTime;
            
        }




        if (Input.GetKey(KeyCode.PageDown))
        {
            Quaternion target = Quaternion.Euler(0 + minAngleArr, 0, 0);

            Arrow1.transform.localRotation = Quaternion.RotateTowards(Arrow1.transform.localRotation, target, Time.deltaTime * ArrowSpeed);

            if(startRotDet.x > 0)
            startRotDet.x = startRotDet.x - ArrowSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Home) )
        {
            startRotDetailBool = false;
            if(startRotDet.x > minAngleDet)
            startRotDet.x = startRotDet.x - ArrowSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.End))
        {
            startRotDetailBool = false;
            if (startRotDet.x < maxAngleDet)
                startRotDet.x = startRotDet.x + ArrowSpeed * Time.deltaTime;
        }

        //the script will be updated
        /*     if (Input.GetKey(KeyCode.H))
             {
                 startRotDetailBool = true;
             }

             if(startRotDetailBool)
             {
                 {
                     startRotDetailBool = false;
                 }
             }*/

        if (Input.GetKey(KeyCode.L))

        {


            Arrow2.transform.localPosition = Vector3.MoveTowards(Arrow2.transform.localPosition, forwardPos, Arrow2SpeedForward * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.K))


        {
            Arrow2.transform.localPosition = Vector3.MoveTowards(Arrow2.transform.localPosition, rearPos, Arrow2SpeedForward * Time.deltaTime);

        }

        detail1.localEulerAngles = startRotDet;

 

    }

}

