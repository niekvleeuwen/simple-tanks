using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CursorScript : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        // center cursor
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.lockState = CursorLockMode.None;   
        // set Cursor to not be visible if not in menu
        if(SceneManager.GetActiveScene().name == "Menu"){
            Cursor.visible = true;
        }else{
            Cursor.visible = false;
        }
    }
}
