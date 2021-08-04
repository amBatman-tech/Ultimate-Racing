﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyRotate : MonoBehaviour {

	public float RotateSpeed = 1.5f;


	void Update () {
	
		RenderSettings.skybox.SetFloat ("_Rotation", RotateSpeed * Time.time);

	}
}
