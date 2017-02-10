using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayHighScore : MonoBehaviour {
	private string label;

	void Start () {
		TextMesh textMesh = GetComponent<TextMesh>();
		label = textMesh.text;
		textMesh.text = label + PlayerPrefs.GetInt("HighScore");
	}
}
