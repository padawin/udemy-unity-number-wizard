using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Intro : MonoBehaviour {
	[SerializeField] TextMeshProUGUI introText;
	[TextArea(10, 14)] [SerializeField] string placeholderText;
	[SerializeField] Rules rules;
	// Use this for initialization
	void Start () {
		introText.text = placeholderText
			.Replace(":ATTEMPTS:", rules.getMaxTurns().ToString())
			.Replace(":MIN:", rules.getMin().ToString())
			.Replace(":MAX:", rules.getMax().ToString());
	}

	// Update is called once per frame
	void Update () {

	}
}
