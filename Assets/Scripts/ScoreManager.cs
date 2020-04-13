using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
	private Text scoreLabel;
	private Text infoLabel;
	private int score = 0;

	void Start () 
	{
		// save the score text object in the scoreLabel field
		GameObject textObj1 = GameObject.FindGameObjectWithTag("ScoreText");
		this.scoreLabel = textObj1.GetComponent<Text>();
		// save the game over text object in the gameOverLabel field
		GameObject textObj2 = GameObject.FindGameObjectWithTag("InfoText");
		this.infoLabel = textObj2.GetComponent<Text>();
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
				StartCoroutine(GoToLevel2(2));
			}else{
				StartCoroutine(GoToMenu(2));
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
 	IEnumerator GoToMenu(int wait)
    {
		infoLabel.color = new Color(255,255,255);
        infoLabel.text = "Thanks for playing!";

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(wait);

		SceneManager.LoadScene("Menu");
    }

	// Function to make the transistion to level 2
 	IEnumerator GoToLevel2(int wait)
    {
		infoLabel.color = new Color(255,255,255);
        infoLabel.text = "Let's go to level 2!";

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(wait);

		SceneManager.LoadScene("LevelTwo");
    }
}
