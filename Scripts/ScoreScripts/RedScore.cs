using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedScore : MonoBehaviour {


	void OnTriggerEnter(){
	
		ScoreMode.CurrentScore += 100;
		gameObject.SetActive (false);
	
	}
}
