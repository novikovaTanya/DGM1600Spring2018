using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickPowerUp : MonoBehaviour {

	public PowerUp myPowerUp;

	void OnMouseDown()
	{
		// Example of using access operator
		myPowerUp.PowerLevel += 10;
		print(myPowerUp.Name);

		if(myPowerUp.PowerLevel >= 100)
		{
			print("I have the Power");
		}
	}
}
