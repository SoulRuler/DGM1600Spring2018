using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathOperators : MonoBehaviour {

public int score = 0;
public int powerup =+ 1;

//public int c = 10;




	void OnTriggerEnter(Collider other)
	{

		score += powerup;

	} 
		
}
