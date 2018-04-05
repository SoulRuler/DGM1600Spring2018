using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveMan : MonoBehaviour {

	public MovePattern MovePattern; 
	private CharacterController controller;

	private void Start()
	{
		controller = GetComponent<CharacterController>();
	}

private void Update()
{
	MovePattern.Move(controller, transform);
}

}