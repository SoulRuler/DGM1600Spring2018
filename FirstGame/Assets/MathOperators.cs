using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathOperators : MonoBehaviour {

public int score = 0;
public int powerup = 10;

//public int c = 10;




	void OnTriggerEnter(Collider other)
	{

		score += powerup;

	} 
		
}


	//	if(a <= 0)
	//	{
	//		a++;
	//	}
	//	if(a >= 10)
	//	{
	//		a--;
	//	}
	//	c = a + b;
	//	c += a + b;
	//	c -= a + b;


//anything++ means + one

//anything-- means - one

//order of operations