using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggerer : MonoBehaviour {

	public PowerUp PowerUpTransfer;
	public Image Healthbar;
	public float PowerLevel = .02;

	public PowerUp PowerUp;

	private void OnTriggerEnter (Collider obj)
	{
		if(HealthBar.FillAmount += PowerUp)
		if(HealthBar.FillAmount > 0)

	}

	public void OnTriggerEnter(Collider obj)
	{
		print(obj.name);
	}

}
