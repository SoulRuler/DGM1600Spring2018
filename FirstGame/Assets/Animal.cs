using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animal : MonoBehaviour {

	public string Name;
	public int foodcount;

	

	void OnMouseDown()
	{
		print(Name + " is going to make sure that the world burns");
		print("foodcount = " + foodcount);
	}



}
