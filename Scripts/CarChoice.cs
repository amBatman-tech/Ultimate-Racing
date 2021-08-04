using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoice : MonoBehaviour {

	public GameObject RedBody;// 1=Red 2=Blue 3=green 4=yellow
	public GameObject BlueBody;
	public GameObject GreenBody;
	public GameObject YellowBody;
	public int CarImport;


	void Start () {

		CarImport = GlobalCar.CarType;
		if (CarImport == 1) {

			RedBody.SetActive (true);
		}

		if (CarImport == 2) {

			BlueBody.SetActive (true);
		}

		if (CarImport == 3) {

			GreenBody.SetActive (true);
		}

		if (CarImport == 4) {

			YellowBody.SetActive (true);
		}
		
	}

}
