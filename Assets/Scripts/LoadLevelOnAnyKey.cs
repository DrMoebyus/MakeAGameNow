using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelOnAnyKey : MonoBehaviour {

	public string levelName;

	void Update () {
		if (Input.anyKeyDown) {
			SceneManager.LoadScene(levelName);
		}
	}
}
