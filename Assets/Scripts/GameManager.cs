using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public static GameManager _instance;

	public static GameManager Instance {
		get {
			if (_instance != null) {
				return _instance;
			}
			else {
				GameObject gameManager = new GameObject("GameManager");
				_instance = gameManager.AddComponent<GameManager>();
				return _instance;
			}
		}
	}

	public float pointsPerUnitTraveld = 1.0f;
	public float gameSpeed = 10.0f;
	public string titleScreenName = "TitleScreen";

	[HideInInspector]
	public int previousScore = 0;

	private static float highScore = 0.0f;
	private float score = 0.0f;
	private bool gameOver = false;
	private bool hasSaved = false;

	void Start () {
		if (_instance != this) {
			if (_instance == null) {
				_instance = this;
			}
			else{
				Destroy(gameObject);
			}
		}
		LoadHighScore();
		DontDestroyOnLoad(gameObject);
	}

	void Update () {
		if (SceneManager.GetActiveScene().name != titleScreenName) {
			if (GameObject.FindGameObjectWithTag("Player") == null)	{
				gameOver = true;
			}

			if (gameOver)	{
				if (!hasSaved) {
					SaveHigheScore();
					previousScore = (int)score;
					hasSaved = true;
				}
				if (Input.anyKeyDown) {
					SceneManager.LoadScene(titleScreenName);
				}
			}

			if (!gameOver) {
				score += pointsPerUnitTraveld * gameSpeed * Time.deltaTime;

				if (score > highScore) {
						highScore = score;
				}
			}
		}
		else {
			//Reset stuff for next game
			ResetGame();
		}
	}

	void ResetGame () {
		score = 0.0f;
		gameOver = false;
		hasSaved = false;
	}

	void SaveHigheScore () {
		PlayerPrefs.SetInt("HighScore", (int)highScore);
		PlayerPrefs.Save();
	}

	void LoadHighScore () {
		highScore = PlayerPrefs.GetInt("HighScore");
	}

	void OnGUI () {
		if (SceneManager.GetActiveScene().name != titleScreenName) {
			int currentScore = (int)score;
			int currentHighScore = (int)highScore;
			GUILayout.Label("Score: " + currentScore.ToString());
			GUILayout.Label("highScore: " + currentHighScore.ToString());

			if (gameOver == true) {
				GUILayout.Label("Game Over!  Press any key to quit!");
			}
		}
	}
}
