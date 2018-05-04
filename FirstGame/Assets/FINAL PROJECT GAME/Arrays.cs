using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysPlusLoops : MonoBehaviour {

	public string[] players;
	public int[] HighScore;
	public PowerUp[] power;


	void Start () {

	foreach (var player in players)
	{

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