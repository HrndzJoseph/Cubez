using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    public void GoToSelection() {
        SceneManager.LoadScene("SelectionMenu");
        FindObjectOfType<AudioManager>().play("Button");

    }
    public void QuitGame(){
        Application.Quit();
        FindObjectOfType<AudioManager>().play("Button");

    }
    
}
