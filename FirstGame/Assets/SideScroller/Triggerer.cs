using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggerer : MonoBehaviour {

	public PowerUp PowerUpTransfer;

	public void OnTriggerEnter(Collider obj)
	{
		print(obj.name);
	}

}
