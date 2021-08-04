using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockedObjects : MonoBehaviour {


	public int GreenSelect;
	public int YellowSelect;
	public GameObject FakeGreen;
	public GameObject FakeYellow;


	void Start () {

		GreenSelect = PlayerPrefs.GetInt ("GreenBought");
		if (GreenSelect == 100) {
		
			FakeGreen.SetActive (false);

		}




		YellowSelect = PlayerPrefs.GetInt ("YellowBought");
		if (YellowSelect == 100) {

			FakeYellow.SetActive (false);

		}

		
	}

}
