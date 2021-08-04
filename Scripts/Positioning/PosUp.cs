using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PosUp : MonoBehaviour {

	public GameObject PositionDisplay;


	void OnTriggerExit(Collider other){
	

		if (other.tag == "CarPos") {
		
			PositionDisplay.GetComponent<Text>().text = "1st Place";
		
		}
	
	
	}


}
