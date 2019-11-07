using UnityEngine;
using System.Collections;

public class CameraLookAt : MonoBehaviour {


    public SelectVehicle selectVehicleScript;


	// Use this for initialization
	void Awake () {
	
	}
	
	// Update is called once per frame
	void Update () {

        transform.LookAt(selectVehicleScript.currentVehicle.transform);

	}
}
