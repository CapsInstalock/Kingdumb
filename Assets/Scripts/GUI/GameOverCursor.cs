﻿using UnityEngine;
using System.Collections;

public class GameOverCursor : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Screen.showCursor = true;
		Screen.lockCursor = false;
	}
}