using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    private Text infoLabel;
    public PlayerMovement playerMovement;

    void Start () 
	{
		// save the game over text object in the infoLabel field
		GameObject textObj = GameObject.FindGameObjectWithTag("InfoText");
		this.infoLabel = textObj.GetComponent<Text>();
	}
    void OnCollisionEnter(Collision collision)
    {   
        if(collision.collider.name == "Target")
        {
            infoLabel.color = new Color(255,0,0);
            infoLabel.text = "GAME OVER";
            // disable player movement
            playerMovement.enabled = false;
            // go to menu after two seconds
            StartCoroutine(GoToMenu(2));
        }
    }

    // Function to make the transistion to level 2
 	IEnumerator GoToMenu(int wait)
    {
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(wait);

		SceneManager.LoadScene("Menu");
    }
}
