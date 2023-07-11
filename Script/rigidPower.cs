using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigidPower : MonoBehaviour
{
    public Rigidbody Rigid;
    public int speed = 5 ;

    private bool isMooving = false;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    void Update()
     {
            if (Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) && isMooving == false)
        {
            isMooving = true;
            Rigid.AddForce(Vector3.forward * speed * Time.deltaTime, ForceMode.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow) && isMooving == false)
        {
            isMooving = true;
            Rigid.AddForce(Vector3.left * speed * Time.deltaTime, ForceMode.Impulse);
            
            
        }
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow) && isMooving == false)
        {
            isMooving = true;
            Rigid.AddForce(Vector3.back * speed * Time.deltaTime, ForceMode.Impulse);
            
            
        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow) && isMooving == false)
        {
            isMooving = true;
            Rigid.AddForce(Vector3.right * speed * Time.deltaTime, ForceMode.Impulse); 
        }

        if (Rigid.velocity.magnitude < 0.1f && isMooving == true)
        {
            isMooving = false;
        }
            
        }
  
          
    }


