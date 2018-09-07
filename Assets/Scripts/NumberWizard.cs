using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour {
	[SerializeField] Rules rules;
	[SerializeField] GameResult result;
	[SerializeField] SceneLoader sceneLoader;

	[SerializeField] TextMeshProUGUI guessText;

	int turn = 0;
	int min;
	int max;
	int guess;

	// Use for initialization
	void Start() {
		min = rules.getMin();
		max = rules.getMax();
		_guess();
	}

	void _guess() {
		turn++;
		if (turn > rules.getMaxTurns()) {
			result.setResult(false);
			sceneLoader.loadNextScene();
		}
		else {
			guess = Random.Range(min, max + 1);
			guessText.SetText(guess.ToString());
		}
	}

	public void clickGuessTooLow() {
		min = Mathf.Min(max, guess + 1);
		_guess();
	}

	public void clickGuessTooHigh() {
		max = Mathf.Max(min, guess - 1);
		_guess();
	}

	public void clickFound() {
		result.setResult(true);
		sceneLoader.loadNextScene();
	}
}
