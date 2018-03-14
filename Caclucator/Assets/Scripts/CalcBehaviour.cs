using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalcBehaviour : MonoBehaviour {

	public InputField InputA, InputB;
	public Text Result;

	public Calculation Calculation;

	public void Run() {
		print (Calculation.Calculate (InputA.text, InputB.text).ToString());
		Result.text = Calculation.Calculate (InputA.text, InputB.text).ToString();
	}
}
