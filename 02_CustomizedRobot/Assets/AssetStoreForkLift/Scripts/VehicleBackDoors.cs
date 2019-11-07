using UnityEngine;
using System.Collections;

public class VehicleBackDoors : MonoBehaviour {

    Animator _anim;

	// Use this for initialization
	void Awake () {

        _anim = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKey(KeyCode.O))
        {
            _anim.SetBool("Open", true);
            _anim.SetBool("Close", false);
        }
        if (Input.GetKey(KeyCode.C))
        {
            _anim.SetBool("Open", false);
            _anim.SetBool("Close", true);
        }

    }
}
