﻿using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void startgame()
	{
		Application.LoadLevel (1);
	}

	public void instructions()
	{
		Application.LoadLevel (3);
	}
}
