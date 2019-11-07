using System.Collections;
using UnityEngine;

[ExecuteInEditMode]
public class kinematicHinge : MonoBehaviour {


    public Transform Hinge1;
    public Transform Hinge2;

    private Vector3 _hinge1Pos;
    private Vector3 _hinge2Pos;

    // Update is called once per frame
    void LateUpdate () {

        if (Hinge1 != null && Hinge2 != null)
        {

            Hinge1.LookAt(Hinge2.position, Hinge1.up);
            Hinge2.LookAt(Hinge1.position, Hinge2.up);

        }
    }
}
