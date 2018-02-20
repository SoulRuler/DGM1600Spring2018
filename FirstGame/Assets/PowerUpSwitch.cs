using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSwitch : MonoBehaviour {

	public Powerup MyPowerUp;


	void Start () {
		
		Switch (MyPowerUp.name)
		{
			case "Ammo":
				print("You just got more ammo");
				break;
		
		}
	}
}
