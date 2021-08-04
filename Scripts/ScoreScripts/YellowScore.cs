using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowScore : MonoBehaviour {


	void OnTriggerEnter(){
	
		ScoreMode.CurrentScore += 25;
		gameObject.SetActive (false);
	
	
	}
}
