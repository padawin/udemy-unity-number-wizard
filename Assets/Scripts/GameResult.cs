using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "GameResult")]
public class GameResult : ScriptableObject {
	bool won = false;

	public void setResult(bool guessFound) {
		Debug.Log(guessFound);
		won = guessFound;
		Debug.Log(won);
	}

	public bool getResult() {
		Debug.Log(won);
		return won;
	}
}
