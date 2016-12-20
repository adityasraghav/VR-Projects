using System;
using UnityEngine;


public class BrakeLights : MonoBehaviour
{
	public UnityStandardAssets.Vehicles.Car.CarController car; // reference to the car controller, must be dragged in inspector
	public GameObject lights;

    private void Update()
    {
		lights.SetActive(car.BrakeInput > 0f);
    }
}
