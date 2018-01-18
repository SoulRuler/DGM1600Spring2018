using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {

	// Use this for initialization
	// This declhairs what start will do
	void Start () {
		print("My animal is eating.");
		print("Now my animal is sleeping.");
		print("Hahaha now he is dead becuase he fell off of a cliff");
	}

	void OnMouseDown()
	{
		print("I'm dead");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
