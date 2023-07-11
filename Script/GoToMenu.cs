using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMenu : MonoBehaviour
{

    public void MenuScene(){
        FindObjectOfType<AudioManager>().play("Button");
        SceneManager.LoadScene("Menu");
        
    }
}
