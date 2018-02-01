using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElseClause : MonoBehaviour {

public bool Keys;
public string password = "OU812";
public int health = 100;

	void Start () {

		if(Keys){

			print("I have the key");

		}

		else{

			print("I dont have a way to get through");
	
		}

		if(health > 0){

			print("can play");

		}

		else{

			print("You are dead");

		}

		if(password == "OU812"){

			print("That is correct");

		}

		else{

			print("Try again");

		}
	
	}

}
	
//	

//

//Else clauses are the oposing side to the if statement

//if if doesnt not do what it is suppose to do then the else clause works

//You wanted rider installed 

//we talked about opperators for a minute

//= is assign value == is chech equality + is plus - is minus != this is check for unqeuality <= >= < > the greater thens less thens 

//we talked about if key (i have the key) or you shall not pass
	

