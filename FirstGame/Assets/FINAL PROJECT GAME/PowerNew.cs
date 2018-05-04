﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerNew : MonoBehaviour {

	public float Multi = 1.4f;

	void OnTriggerEnter(Collider other)
	{
			if (other.CompareTag("Player"))
			{
				Pickup(other);
			}

	}

	void Pickup(Collider player)
	{
		
		player.transform.localScale *= Multi; 

		

	}


}
