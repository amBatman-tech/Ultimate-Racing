using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

	public static bool GameIsPaused = false;
	public GameObject PauseMenuUI;
	public GameObject RaceUI;
	public GameObject LapUI;
	public GameObject PlaceUI;
	public GameObject MapUI;
	

	void Update () {

		if (Input.GetKeyDown (KeyCode.Escape)) {
		
			if (GameIsPaused) {
			
				Resume ();
			
			} else {
			
				Pause ();
			
			}
		
		}
		
	}

	public void Resume(){
	
		PauseMenuUI.SetActive (false);
		RaceUI.SetActive (true);
		LapUI.SetActive (true);
		PlaceUI.SetActive (true);
		MapUI.SetActive (true);
		Time.timeScale = 1f;
		GameIsPaused = false;
	
	
	}

	void Pause(){
	
	
		PauseMenuUI.SetActive (true);
		RaceUI.SetActive (false);
		LapUI.SetActive (false);
		PlaceUI.SetActive (false);
		MapUI.SetActive (false);
		Time.timeScale = 0f;
		GameIsPaused = true;
	
	}
}
