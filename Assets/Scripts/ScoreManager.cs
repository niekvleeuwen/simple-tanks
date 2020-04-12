using UnityEngine;
using UnityEngine.UI;
using System.Collections;

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

	public void AddToScore()
	{
		this.score++;
		// Display the new score on the screen
		scoreLabel.text = "Score: " + score;
	}
}
