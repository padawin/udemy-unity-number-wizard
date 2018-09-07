using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour {
	[SerializeField] Rules rules;
	[SerializeField] SceneLoader sceneLoader;

	[SerializeField] TextMeshProUGUI guessText;

	int turn = 0;
	int? min = null;
	int? max = null;
	int? guess = null;

	// Use for initialization
	void Start() {
		min = rules.getMin();
		max = rules.getMax();
		_guess();
	}

	void _guess() {
		guess = (max + min) / 2;
		turn++;
		if (turn > rules.getMaxTurns()) {
			sceneLoader.loadNextScene();
		}
		else {
			guessText.SetText(guess.ToString());
		}
	}

	public void clickGuessTooLow() {
		min = guess;
		_guess();
	}

	public void clickGuessTooHigh() {
		max = guess;
		_guess();
	}
}
