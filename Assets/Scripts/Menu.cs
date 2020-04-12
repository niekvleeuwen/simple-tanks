using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
	public string level1;
	public string level2;

	// Function to be executed when pressing play level 1 button
	public void LoadLevel1()
	{
		LoadLevel(level1);
	}

	// Function to be executed when pressing play level 2 button
	public void LoadLevel2()
	{
		LoadLevel(level2);
	}

	// Function to be executed when pressing quit button
	public void Quit()
    {
         #if UNITY_EDITOR
             // Application.Quit() does not work in the editor
             UnityEditor.EditorApplication.isPlaying = false;
         #else
             Application.Quit();
         #endif
    }

	// Function to load a level
	private void LoadLevel(string levelName){
		SceneManager.LoadScene(levelName);
	}
}
