using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameOver = false;

	void Start ()
	{
		
	}

	void Update ()
	{
		if (GameObject.FindGameObjectWithTag("Player") == null)
        {
            gameOver = true;
        }

        if (gameOver)
        {
            if (Input.anyKeyDown)
            {
                SceneManager.LoadScene("Level1");
            }
        }
	}

    void OnGUI ()
    {
        if (gameOver == true)
        {
            GUILayout.Label("Game Over!  Press any key to reset!");
        }
    }
}