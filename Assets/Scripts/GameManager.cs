using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public static GameManager Instance;

	public float pointsPerUnitTraveld = 1.0f;
	public float gameSpeed = 10.0f;

	private float score = 0.0f;
	private bool gameOver = false;
	private static float highScore = 0.0f;

	void Start () {
		Instance = this;
	}

	void Update () {
		if (GameObject.FindGameObjectWithTag("Player") == null)	{
			gameOver = true;
		}

		if (gameOver)	{
			if (Input.anyKeyDown) {
				SceneManager.LoadScene("Level1");
			}
		}

		if (!gameOver) {
			score += pointsPerUnitTraveld * gameSpeed * Time.deltaTime;

			if (score > highScore) {
					highScore = score;
			}
		}
	}

	void OnGUI () {
		int currentScore = (int)score;
		int currentHighScore = (int)highScore;
		GUILayout.Label("Score: " + currentScore.ToString());
		GUILayout.Label("highScore: " + currentHighScore.ToString());

		if (gameOver == true) {
			GUILayout.Label("Game Over!  Press any key to reset!");
		}
	}
}
