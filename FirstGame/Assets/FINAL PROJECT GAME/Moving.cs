
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour {

	public MovePattern MovePattern; 
	private CharacterController controller;

	private void Start()
	{
		controller = GetComponent<CharacterController>();
	}

}