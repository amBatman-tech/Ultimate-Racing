﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;



public class RaceFinish : MonoBehaviour {

	public GameObject MyCar;
	public GameObject FinishCam;
	public GameObject ViewModes;
	public GameObject LevelMusic;
	public AudioSource FinishMusic;
	public GameObject CompleteTrig;


	void OnTriggerEnter(){

		if (TimeMode.isTimeMode == true) {
		
			//we are on RaceTimeMode

		
		} else {
		
			this.GetComponent<BoxCollider> ().enabled = false;
			MyCar.SetActive (false);
			CompleteTrig.SetActive (false);
			CarController.m_Topspeed = 0.0f;
			MyCar.GetComponent<CarController> ().enabled = false;
			MyCar.GetComponent<CarUserControl> ().enabled = false;
			MyCar.SetActive (true);
			FinishCam.SetActive (true);
			LevelMusic.SetActive (false);
			ViewModes.SetActive (false);
			FinishMusic.Play ();

			GlobalCash.TotalCash += 100;
			PlayerPrefs.SetInt ("SavedCash", GlobalCash.TotalCash);
		
		}
			


	
	}
}
