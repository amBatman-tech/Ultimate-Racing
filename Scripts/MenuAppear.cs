using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAppear : MonoBehaviour {



	public GameObject LargeButton;
	public GameObject TextClick;
	public GameObject MenuButton;

	public void StartMenu(){
	
		TextClick.SetActive (false);
		MenuButton.SetActive (true);
		LargeButton.SetActive (false);	
	}

}
