using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElseClauses : MonoBehaviour {

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