using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public abstract class Calculation : ScriptableObject {

	public float anum;
	public float bnum;

	public abstract float Calculate (string a, string b);


	//public float anum;
	//public float bnum;


	
//public string Add (string a, string b)
//{
	//anum = float.Parse(a);
	//bnum = float.Parse(b);
	//return (anum + bnum).ToString();

//}

	//public abstract string RunCalculation ();

}

