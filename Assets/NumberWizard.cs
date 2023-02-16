using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
	int MaxGuess { get; set; }
	int MinGuess { get; set; }
	int Guess { get; set; }

	// Start is called before the first frame update
	void Start() {
		Debug.Log("Welcome to Number Wizard!");
		StartGame();
		MaxGuess++;
	}

	void StartGame() {
		MaxGuess = 1000;
		MinGuess = 1;
		UpdateGuess();
		Debug.Log("Please think of a number...");
		Debug.Log($"Minimum number is {String.Format("{0:n0}", MinGuess)}");
		Debug.Log($"Maximum number is {String.Format("{0:n0}", MaxGuess)}");
		DisplayGuess();
	}

	// Update is called once per frame
	void Update() {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			MinGuess = Guess;
			UpdateGuess();
			DisplayGuess();
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			MaxGuess = Guess;
			UpdateGuess();
			DisplayGuess();
		} else if (Input.GetKeyDown(KeyCode.Return)) {
			Debug.Log($"{Guess}!  Got it on the first try!");
			StartGame();
		}
	}

	void UpdateGuess() {
		Guess = (MaxGuess + MinGuess) / 2;
	}

	void DisplayGuess() {
		Debug.Log($"My guess is that your number is...{String.Format("{0:n0}", Guess)}");
		Debug.Log("Tell me if your number is higher or lower than my guess.");
		Debug.Log("Press Up if higher, press Down if lower, press Enter if correct.");
	}
}
