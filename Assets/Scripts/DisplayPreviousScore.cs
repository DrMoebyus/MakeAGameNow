using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayPreviousScore : MonoBehaviour {
	private string label;

	void Start () {
		TextMesh textMesh = GetComponent<TextMesh>();
		label = textMesh.text;
		textMesh.text = label + GameManager.Instance.previousScore;
	}
}
