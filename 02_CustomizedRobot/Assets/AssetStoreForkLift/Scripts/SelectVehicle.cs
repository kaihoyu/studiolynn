using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class SelectVehicle : MonoBehaviour {

 
    public GameObject Van;
    public GameObject ForkLift;
    public GameObject Truck;
    public GameObject TruckRef;
    public GameObject TruckBoards;
    public GameObject Trailer;
    public GameObject TrailerRef;
    public GameObject TrailerBoards;
    public GameObject Truck4x4;
    public GameObject HeavyTruck;
    public GameObject TruckKenw;
    public GameObject TelehandlerForklift;
    public GameObject uiText;
    public Text UICurrentCar;
     
    public GameObject currentVehicle;
	// Use this for initialization
	void Start () {
	    

        ForkLift.GetComponent<NewCarUserControl>().enabled = true;
        ForkLift.GetComponent<ForkController>().enabled = true;
        Van.GetComponent<NewCarUserControl>().enabled = false;
        Van.GetComponent<VehicleBackDoors>().enabled = false;
        Truck.GetComponent<NewCarUserControl>().enabled = false;
        Trailer.GetComponent<VehicleBackDoors>().enabled = false;
        TruckRef.GetComponent<NewCarUserControl>().enabled = false;
        TrailerRef.GetComponent<VehicleBackDoors>().enabled = false;
        TruckBoards.GetComponent<NewCarUserControl>().enabled = false;
        TrailerBoards.GetComponent<VehicleBackDoors>().enabled = false;
        Truck4x4.GetComponent<VehicleBackDoors>().enabled = false;
        Truck4x4.GetComponent<NewCarUserControl>().enabled = false;
	    HeavyTruck.GetComponent<NewCarUserControl>().enabled = false;
        TruckKenw.GetComponent<NewCarUserControl>().enabled = false;
        TelehandlerForklift.GetComponent<NewCarUserControl>().enabled = false;

        currentVehicle = ForkLift;
    }
	
	// Update is called once per frame
	void Update () {
        if (UICurrentCar != null)
        {
            UICurrentCar.text = "Current vehicle: " + currentVehicle.name;
        }
        if (Input.GetKey(KeyCode.Alpha1))
        {
            ForkLift.GetComponent<NewCarUserControl>().enabled = true;
            ForkLift.GetComponent<ForkController>().enabled = true;
            
            Van.GetComponent<NewCarUserControl>().enabled = false;
            Van.GetComponent<VehicleBackDoors>().enabled = false;

            Truck.GetComponent<NewCarUserControl>().enabled = false;
            Trailer.GetComponent<VehicleBackDoors>().enabled = false;

            TruckRef.GetComponent<NewCarUserControl>().enabled = false;
            TrailerRef.GetComponent<VehicleBackDoors>().enabled = false;

            TruckBoards.GetComponent<NewCarUserControl>().enabled = false;
            TrailerBoards.GetComponent<VehicleBackDoors>().enabled = false;

            Truck4x4.GetComponent<VehicleBackDoors>().enabled = false;
            Truck4x4.GetComponent<NewCarUserControl>().enabled = false;
	        HeavyTruck.GetComponent<NewCarUserControl>().enabled = false;

            TruckKenw.GetComponent<NewCarUserControl>().enabled = false;

            TelehandlerForklift.GetComponent<NewCarUserControl>().enabled = false;
            TelehandlerForklift.GetComponent<TelehandlerForkliftController>().enabled = false;

            currentVehicle = ForkLift;
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            ForkLift.GetComponent<NewCarUserControl>().enabled = false;
            ForkLift.GetComponent<ForkController>().enabled = false;

            Truck.GetComponent<NewCarUserControl>().enabled = false;
            Trailer.GetComponent<VehicleBackDoors>().enabled = false;

            Van.GetComponent<NewCarUserControl>().enabled = true;
            Van.GetComponent<VehicleBackDoors>().enabled = true;

            TruckRef.GetComponent<NewCarUserControl>().enabled = false;
            TrailerRef.GetComponent<VehicleBackDoors>().enabled = false;

            TruckBoards.GetComponent<NewCarUserControl>().enabled = false;
            TrailerBoards.GetComponent<VehicleBackDoors>().enabled = false;

            Truck4x4.GetComponent<VehicleBackDoors>().enabled = false;
            Truck4x4.GetComponent<NewCarUserControl>().enabled = false;

	        HeavyTruck.GetComponent<NewCarUserControl>().enabled = false;

            TruckKenw.GetComponent<NewCarUserControl>().enabled = false;

            TelehandlerForklift.GetComponent<NewCarUserControl>().enabled = false;
            TelehandlerForklift.GetComponent<TelehandlerForkliftController>().enabled = false;

            currentVehicle = Van;
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            ForkLift.GetComponent<NewCarUserControl>().enabled = false;
            ForkLift.GetComponent<ForkController>().enabled = false;

            Truck.GetComponent<NewCarUserControl>().enabled = true;
            Trailer.GetComponent<VehicleBackDoors>().enabled = true;

            Van.GetComponent<NewCarUserControl>().enabled = false;
            Van.GetComponent<VehicleBackDoors>().enabled = false;

            TruckRef.GetComponent<NewCarUserControl>().enabled = false;
            TrailerRef.GetComponent<VehicleBackDoors>().enabled = false;

            TruckBoards.GetComponent<NewCarUserControl>().enabled = false;
            TrailerBoards.GetComponent<VehicleBackDoors>().enabled = false;

            Truck4x4.GetComponent<VehicleBackDoors>().enabled = false;
            Truck4x4.GetComponent<NewCarUserControl>().enabled = false;

	        HeavyTruck.GetComponent<NewCarUserControl>().enabled = false;

            TruckKenw.GetComponent<NewCarUserControl>().enabled = false;

            TelehandlerForklift.GetComponent<NewCarUserControl>().enabled = false;
            TelehandlerForklift.GetComponent<TelehandlerForkliftController>().enabled = false;

            currentVehicle = Truck;
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            ForkLift.GetComponent<NewCarUserControl>().enabled = false;
            ForkLift.GetComponent<ForkController>().enabled = false;

            Truck.GetComponent<NewCarUserControl>().enabled = false;
            Trailer.GetComponent<VehicleBackDoors>().enabled = false;

            Van.GetComponent<NewCarUserControl>().enabled = false;
            Van.GetComponent<VehicleBackDoors>().enabled = false;

            TruckRef.GetComponent<NewCarUserControl>().enabled = true;
            TrailerRef.GetComponent<VehicleBackDoors>().enabled = true;

            TruckBoards.GetComponent<NewCarUserControl>().enabled = false;
            TrailerBoards.GetComponent<VehicleBackDoors>().enabled = false;

            Truck4x4.GetComponent<VehicleBackDoors>().enabled = false;
            Truck4x4.GetComponent<NewCarUserControl>().enabled = false;
    
	        HeavyTruck.GetComponent<NewCarUserControl>().enabled = false;

            TruckKenw.GetComponent<NewCarUserControl>().enabled = false;

            TelehandlerForklift.GetComponent<NewCarUserControl>().enabled = false;
            TelehandlerForklift.GetComponent<TelehandlerForkliftController>().enabled = false;

            currentVehicle = TruckRef;
        }

        if (Input.GetKey(KeyCode.Alpha5))
        {
            ForkLift.GetComponent<NewCarUserControl>().enabled = false;
            ForkLift.GetComponent<ForkController>().enabled = false;

            Truck.GetComponent<NewCarUserControl>().enabled = false;
            Trailer.GetComponent<VehicleBackDoors>().enabled = false;

            Van.GetComponent<NewCarUserControl>().enabled = false;
            Van.GetComponent<VehicleBackDoors>().enabled = false;

            TruckRef.GetComponent<NewCarUserControl>().enabled = false;
            TrailerRef.GetComponent<VehicleBackDoors>().enabled = false;

            TruckBoards.GetComponent<NewCarUserControl>().enabled = true;
            TrailerBoards.GetComponent<VehicleBackDoors>().enabled = true;

            Truck4x4.GetComponent<VehicleBackDoors>().enabled = false;
            Truck4x4.GetComponent<NewCarUserControl>().enabled = false;

	        HeavyTruck.GetComponent<NewCarUserControl>().enabled = false;

            TruckKenw.GetComponent<NewCarUserControl>().enabled = false;

            TelehandlerForklift.GetComponent<NewCarUserControl>().enabled = false;
            TelehandlerForklift.GetComponent<TelehandlerForkliftController>().enabled = false;

            currentVehicle = TruckBoards;
        }

        if (Input.GetKey(KeyCode.Alpha6))
        {
            ForkLift.GetComponent<NewCarUserControl>().enabled = false;
            ForkLift.GetComponent<ForkController>().enabled = false;

            Truck.GetComponent<NewCarUserControl>().enabled = false;
            Trailer.GetComponent<VehicleBackDoors>().enabled = false;

            Van.GetComponent<NewCarUserControl>().enabled = false;
            Van.GetComponent<VehicleBackDoors>().enabled = false;

            TruckRef.GetComponent<NewCarUserControl>().enabled = false;
            TrailerRef.GetComponent<VehicleBackDoors>().enabled = false;

            TruckBoards.GetComponent<NewCarUserControl>().enabled = false;
            TrailerBoards.GetComponent<VehicleBackDoors>().enabled = false;

            Truck4x4.GetComponent<VehicleBackDoors>().enabled = true;
            Truck4x4.GetComponent<NewCarUserControl>().enabled = true;

	        HeavyTruck.GetComponent<NewCarUserControl>().enabled = false;

            TruckKenw.GetComponent<NewCarUserControl>().enabled = false;

            TelehandlerForklift.GetComponent<NewCarUserControl>().enabled = false;
            TelehandlerForklift.GetComponent<TelehandlerForkliftController>().enabled = false;

            currentVehicle = Truck4x4;
        }
	if (Input.GetKey(KeyCode.Alpha7))
        {
            ForkLift.GetComponent<NewCarUserControl>().enabled = false;
            ForkLift.GetComponent<ForkController>().enabled = false;

            Truck.GetComponent<NewCarUserControl>().enabled = false;
            Trailer.GetComponent<VehicleBackDoors>().enabled = false;

            Van.GetComponent<NewCarUserControl>().enabled = false;
            Van.GetComponent<VehicleBackDoors>().enabled = false;

            TruckRef.GetComponent<NewCarUserControl>().enabled = false;
            TrailerRef.GetComponent<VehicleBackDoors>().enabled = false;

            TruckBoards.GetComponent<NewCarUserControl>().enabled = false;
            TrailerBoards.GetComponent<VehicleBackDoors>().enabled = false;

            Truck4x4.GetComponent<VehicleBackDoors>().enabled = false;
            Truck4x4.GetComponent<NewCarUserControl>().enabled = false;

	        HeavyTruck.GetComponent<NewCarUserControl>().enabled = true;

            TruckKenw.GetComponent<NewCarUserControl>().enabled = false;

            TelehandlerForklift.GetComponent<NewCarUserControl>().enabled = false;
            TelehandlerForklift.GetComponent<TelehandlerForkliftController>().enabled = false;

            currentVehicle = HeavyTruck;
        }

        if (Input.GetKey(KeyCode.Alpha8))
        {
            ForkLift.GetComponent<NewCarUserControl>().enabled = false;
            ForkLift.GetComponent<ForkController>().enabled = false;

            Truck.GetComponent<NewCarUserControl>().enabled = false;
            Trailer.GetComponent<VehicleBackDoors>().enabled = false;

            Van.GetComponent<NewCarUserControl>().enabled = false;
            Van.GetComponent<VehicleBackDoors>().enabled = false;

            TruckRef.GetComponent<NewCarUserControl>().enabled = false;
            TrailerRef.GetComponent<VehicleBackDoors>().enabled = false;

            TruckBoards.GetComponent<NewCarUserControl>().enabled = false;
            TrailerBoards.GetComponent<VehicleBackDoors>().enabled = false;

            Truck4x4.GetComponent<VehicleBackDoors>().enabled = false;
            Truck4x4.GetComponent<NewCarUserControl>().enabled = false;

            HeavyTruck.GetComponent<NewCarUserControl>().enabled = false;

            TruckKenw.GetComponent<NewCarUserControl>().enabled = true;

            TelehandlerForklift.GetComponent<NewCarUserControl>().enabled = false;
            TelehandlerForklift.GetComponent<TelehandlerForkliftController>().enabled = false;

            currentVehicle = TruckKenw;
        }
        if (Input.GetKey(KeyCode.Alpha9))
        {
            ForkLift.GetComponent<NewCarUserControl>().enabled = false;
            ForkLift.GetComponent<ForkController>().enabled = false;

            Truck.GetComponent<NewCarUserControl>().enabled = false;
            Trailer.GetComponent<VehicleBackDoors>().enabled = false;

            Van.GetComponent<NewCarUserControl>().enabled = false;
            Van.GetComponent<VehicleBackDoors>().enabled = false;

            TruckRef.GetComponent<NewCarUserControl>().enabled = false;
            TrailerRef.GetComponent<VehicleBackDoors>().enabled = false;

            TruckBoards.GetComponent<NewCarUserControl>().enabled = false;
            TrailerBoards.GetComponent<VehicleBackDoors>().enabled = false;

            Truck4x4.GetComponent<VehicleBackDoors>().enabled = false;
            Truck4x4.GetComponent<NewCarUserControl>().enabled = false;

            HeavyTruck.GetComponent<NewCarUserControl>().enabled = false;

            TruckKenw.GetComponent<NewCarUserControl>().enabled = false;

            TelehandlerForklift.GetComponent<NewCarUserControl>().enabled = true;
            TelehandlerForklift.GetComponent<TelehandlerForkliftController>().enabled = true;
            currentVehicle = TelehandlerForklift;
        }
        if(TelehandlerForklift.GetComponent<NewCarUserControl>().enabled == true)
        {
            uiText.gameObject.SetActive(true);

        }
        else
        {
            uiText.gameObject.SetActive(false);

        }
    }

}
