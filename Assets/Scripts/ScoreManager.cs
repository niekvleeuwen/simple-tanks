using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
	private Text scoreLabel;
	private int score = 0;

	void Start () 
	{
		// save the score text object in the scoreLabel field
		GameObject textObj = GameObject.FindGameObjectWithTag("ScoreText");
		this.scoreLabel = textObj.GetComponent<Text>();
	}

	void Update()
	{
		// Check if the level has ended
		checkEndLevel();
	}

	public void AddToScore()
	{
		this.score++;
		// Display the new score on the screen
		scoreLabel.text = "Score: " + score;
		checkEndLevel();
	}

	private void checkEndLevel()
	{
		if(checkAllTargetsDestroyed())
		{
			if(SceneManager.GetActiveScene().name == "LevelOne"){
				StartCoroutine(GoToLevel2());
			}else{
				StartCoroutine(GoToMenu());
			}
			 
		}
	}

	// Function to check if all the targets are destroyed
	private bool checkAllTargetsDestroyed()
	{
		GameObject[] arr;
		arr = GameObject.FindGameObjectsWithTag("Target");
        if (arr.Length == 0) 
		{
        	return true;
        }
		return false;
	}

	// Function to make the transistion to level 2
 	IEnumerator GoToMenu()
    {
        scoreLabel.text = "Thanks for playing!";

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(2);

		SceneManager.LoadScene("Menu");
    }

	// Function to make the transistion to level 2
 	IEnumerator GoToLevel2()
    {
        scoreLabel.text = "Let's go to level 2!";

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(2);

		SceneManager.LoadScene("LevelTwo");
    }
}
