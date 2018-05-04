using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculationStuff : MonoBehaviour {

	public InputField TextBox1;
	public InputField TextBox2;

	public Text SolutionText;

	public Calc Calc;

	public void RunCalculation()
	{
		SolutionText.text = Calc.Calculate(TextBox1.text, TextBox2.text).ToString();
	}

}