using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsWithPeramiters : MonoBehaviour {
	
	public int Health = 20;

	public int Mana = 0;

	void OnTriggerEnter(Collider other)
	{
		
		AddHealth(25);

		AddMana(50);

		print("Hit something");

		print(other);

		AddNumbers(14, 2);

		PlayerData ("Bob");

		ASign("Woot");

		CrazyNumbers(10, 3, -9);

		GoAway("Boyo");

		Death(-5, 65);

	}

	void AddHealth(int NewHealth)
	{
		Health += NewHealth;
	}

	void AddNumbers(int a, int b)
	{
		print(a += b);
	}

	void PlayerData(string Name)
	{
		print("This Player is " + Name);
	}

	void AddMana(int NewMana)
	{
		Mana += NewMana;
	}

	void ASign(string Sign)
	{
		print("Hey, This is a sign, woot woot");
	}

	void CrazyNumbers(int c, int d, int e)
	{
		print(c + d + e);
	}

	void GoAway(string Boyo)
	{
		print("boyo" + Boyo);
	}

	void Death(int x, int y)
	{
		print(x -= y);
	}

}