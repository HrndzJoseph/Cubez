using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseLevel : MonoBehaviour
{
    public void LVL1(){
        SceneManager.LoadScene("Level 1");
        FindObjectOfType<AudioManager>().play("Button");
    }
    public void LVL2(){
        SceneManager.LoadScene("Level 2");
        FindObjectOfType<AudioManager>().play("Button");
    }
    public void LVL3(){
        SceneManager.LoadScene("Level 3");
        FindObjectOfType<AudioManager>().play("Button");
    }
    public void LVL4(){
        SceneManager.LoadScene("Level 4");
        FindObjectOfType<AudioManager>().play("Button");
    }
    public void LVL5(){
        SceneManager.LoadScene("Level 5");
        FindObjectOfType<AudioManager>().play("Button");
    }
}
