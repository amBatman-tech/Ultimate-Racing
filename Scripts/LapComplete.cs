﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LapComplete : MonoBehaviour {

	public GameObject LapCompleteTrig;
	public GameObject HalfLapTrig;

	public GameObject MinuteDisplay;
	public GameObject SecondDisplay;
	public GameObject MiliDisplay;

	public GameObject LapTimeBox;

	public GameObject LapCounter;
	public int LapsDone;


	public float RawTime;


	public GameObject RaceFinish;


	void Update () {

		if (LapsDone == 1) {

			RaceFinish.SetActive (true);
		
		}

	}

	void OnTriggerEnter () {


		LapsDone += 1;

		RawTime = PlayerPrefs.GetFloat ("RawTime");
		if (LapTimeManager.RawTime <= RawTime) {


			if (LapTimeManager.SecondCount <= 9) {
				SecondDisplay.GetComponent<Text> ().text = "0" + LapTimeManager.SecondCount + ".";
			} else {
				SecondDisplay.GetComponent<Text> ().text = "" + LapTimeManager.SecondCount + ".";
			}

			if (LapTimeManager.MinuteCount <= 9) {
				MinuteDisplay.GetComponent<Text> ().text = "0" + LapTimeManager.MinuteCount + ".";
			} else {
				MinuteDisplay.GetComponent<Text> ().text = "" + LapTimeManager.MinuteCount + ".";
			}

			MiliDisplay.GetComponent<Text> ().text = "" + LapTimeManager.MiliCount;

		}
		PlayerPrefs.SetInt ("MinSave", LapTimeManager.MinuteCount);
		PlayerPrefs.SetInt ("SecSave", LapTimeManager.SecondCount);
		PlayerPrefs.SetFloat ("MiliSave", LapTimeManager.MiliCount);

		PlayerPrefs.SetFloat ("RawTime", LapTimeManager.RawTime);

		LapTimeManager.MinuteCount = 0;
		LapTimeManager.SecondCount = 0;
		LapTimeManager.MiliCount = 0;
		LapTimeManager.RawTime = 0;

		LapCounter.GetComponent<Text> ().text = "" + LapsDone;

		HalfLapTrig.SetActive (true);
		LapCompleteTrig.SetActive (false);

	}

}
