using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickPowerup : MonoBehaviour {

public PowerUp mypowerup;

	public void OnMouseDown()
	{

		//do work
		mypowerup.runpowerup();

	}
}
