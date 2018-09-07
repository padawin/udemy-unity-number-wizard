using UnityEngine;
using TMPro;

public class EndGame : MonoBehaviour {
	[SerializeField] GameResult result;
	[SerializeField] TextMeshProUGUI winText;
	[SerializeField] TextMeshProUGUI loseText;

	// Use this for initialization
	void Start () {
		Debug.Log(result.getResult());
		winText.enabled = result.getResult();
		loseText.enabled = !result.getResult();
	}
}
