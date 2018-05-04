
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class Calc :  Calculation {

	

	public string RunCalcation ()
	{

		return (anum + bnum).ToString();
}

public override float Calculate(string a, string b)
{
	anum = float.Parse(a);

	bnum = float.Parse(b);

	return anum + bnum;
}

}