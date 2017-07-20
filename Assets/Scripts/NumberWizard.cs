using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	

	int max;
	int min;
	int guess;

	void Start () {
		StartGame();
	}

	// Use this for initialization
	void StartGame () {
		max = 1000;
		min = 1;
		guess = 500;

		print ("===========================");
		print ("Welcome to Nmumber Wizard");
		print ("Pick a number in your head, but do not tell me!");

		print ("The highest number you can pick is "+ max);
		print ("The lowest you can pick is " + min);

		print ("Is the number higher or lower than " +guess);
		print ("Up arrow for higher, down for lower, return for equal");

		max = max +1;
	}




	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			print("Up arrow pressed");
			min = guess;
			NextGuess();
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			max = guess;
			NextGuess();
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			print("I won!");
			StartGame ();
		}       
	}


	void NextGuess () {
		guess = (max + min)/2;
		print ("Higher or lower than " + guess);
		print ("Up = higher, down = lower, return = equal");
	}
}
