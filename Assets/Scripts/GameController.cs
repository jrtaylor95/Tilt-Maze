using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.R)) {
			UnityEngine.SceneManagement.SceneManager.LoadScene ("Maze_0");
		} else if (Input.GetKeyUp (KeyCode.Q)) {
			Application.Quit ();
		}
	}
}
