using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputs : MonoBehaviour
{
    public void OnLeft(){
        
    }

    public void OnRight(){
        transform.position += Vector3.right;
    }

    public void OnUp(){
        transform.position += Vector3.forward;
    }

    public void OnDown(){
        transform.position += Vector3.back;
    }
}
