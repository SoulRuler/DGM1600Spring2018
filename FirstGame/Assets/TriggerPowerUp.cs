using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPowerUp : MonoBehaviour {

public Player MyPlayer;

public PowerUp MyPowerUp;

private void OnTriggerEnter()
{
	AddPower(MyPowerUp);
}

void AddPower(PowerUp powerUp)
{
	print(powerUp.PowerLevel);
	MyPlayer.Health =+ MyPowerUp.PowerLevel;
}



}
