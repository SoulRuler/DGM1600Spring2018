using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngineCollider;

public class PowerUpTrigger : MonoBehaviour {

public PowerUpTwo PowerUp;

private void OnTriggerEnter(Collider obj)
{
	obj.GetComponent<MoveCharacter>().MovePattern = PowerUp.MovePattern;
	gameObject.SetActive(false);
}

}
