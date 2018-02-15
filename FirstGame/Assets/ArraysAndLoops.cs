using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysAndLoops : MonoBehaviour {

	public string[] players;
	public int[] HighScore;
	public PowerUp[] power;


	void Start () {

	foreach (var player in players)
	{
		//print(player.PlayerName);
		//print(player.score);
		//print(player.MP);
		print(player);
	}

	foreach (var score in HighScore)
	{
		if (score >= 1000)
		{
			print(score);	
		}

	}

}

}

//You can put score in and var in the for each

// you can make up to 1000 lists if you please

//game objects can also be a part of this

//these can react with other objects and lists

//An array is a box that comtains more boxes (i think that is what you said)

//An array is like a fence post with slats, I have an array of slats with post in the middle

//Arrays start with 0 and they can be as big or as small as you want, it can have as many slats as you want

//but they have to be the same type (not all the same date but the same types yes)

//example, string[] players (Then you can put as many players as you want)

//for each "String" player in the players collection, do some work