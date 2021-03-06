﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Rules")]
public class Rules : ScriptableObject {
	[SerializeField] int min;
	[SerializeField] int max;

	public int getMin() {
		return min;
	}

	public int getMax() {
		return max;
	}

	public int getMaxTurns() {
		int turns = Mathf.FloorToInt(Mathf.Log(max, 2));
		return turns;
	}
}
