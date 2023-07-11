using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class closeTheUi : MonoBehaviour
{
    public GameObject TutoUi;
    public GameObject Ui;

    public void CloseUi(){
        TutoUi.SetActive(false);
        Ui.SetActive(true);
        FindObjectOfType<AudioManager>().play("Button");

    }

    public void OpenUi(){
        TutoUi.SetActive(true);
        Ui.SetActive(false);
        FindObjectOfType<AudioManager>().play("Button");

    }
    
    
}
