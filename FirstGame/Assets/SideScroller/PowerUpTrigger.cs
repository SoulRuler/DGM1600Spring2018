using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngineCollider;

public class PowerUpTrigger : MonoBehaviour {

public PowerUpTwo PowerUp;
	public PowerUp PowerUpTransfer;
	public Image Healthbar;
	public float PowerLevel = .02;



	private void OnTriggerEnter (Collider obj)
	{
		if(HealthBar.FillAmount += PowerUp)
		if(HealthBar.FillAmount > 0)

	}

private void OnTriggerEnter(Collider obj)
{
	obj.GetComponent<MoveCharacter>().MovePattern = PowerUp.MovePattern;
	gameObject.SetActive(false);
}

}
