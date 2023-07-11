using UnityEngine;

public class SlideIndefinitely : MonoBehaviour
{
    public float speed = 5f; // Speed of the object's movement
    private bool isSlidingR = false;
    private bool isSlidingL = false;
    private bool isSlidingU = false;
    private bool isSlidingD = false; // Indicates if the object is currently sliding

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D) && !isSlidingR)
        {
            isSlidingR = true;
            isSlidingL = false;
            isSlidingU = false;
            isSlidingD = false;
        }
        else if (Input.GetKeyDown(KeyCode.Q) && !isSlidingL)
        {
            isSlidingR = false;
            isSlidingL = true;
            isSlidingU = false;
            isSlidingD = false;
        }
        else if (Input.GetKeyDown(KeyCode.Z) && !isSlidingU)
        {
            isSlidingR = false;
            isSlidingL = false;
            isSlidingU = true;
            isSlidingD = false;
        }
        else if (Input.GetKeyDown(KeyCode.S) && !isSlidingD)
        {
            isSlidingR = false;
            isSlidingL = false;
            isSlidingU = false;
            isSlidingD = true;
        }
        
    }

    void FixedUpdate()
    {
        if (isSlidingR)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            Collider[] hitColliders = Physics.OverlapBox(transform.position, transform.localScale / 2, Quaternion.identity);
            foreach (Collider col in hitColliders)
            {
                if (col.gameObject != gameObject)
                {
                    isSlidingR = false;
                    break;
                }
            }
        }
        else if (isSlidingL)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            Collider[] hitColliders = Physics.OverlapBox(transform.position, transform.localScale / 2, Quaternion.identity);
            foreach (Collider col in hitColliders)
            {
                if (col.gameObject != gameObject)
                {
                    isSlidingL = false;
                    break;
                }
            }
        }
        else if (isSlidingU)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            Collider[] hitColliders = Physics.OverlapBox(transform.position, transform.localScale / 2, Quaternion.identity);
            foreach (Collider col in hitColliders)
            {
                if (col.gameObject != gameObject)
                {
                    isSlidingU = false;
                    break;
                }
            }
        }
        else if (isSlidingD)
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
            Collider[] hitColliders = Physics.OverlapBox(transform.position, transform.localScale / 2, Quaternion.identity);
            foreach (Collider col in hitColliders)
            {
                if (col.gameObject != gameObject)
                {
                    isSlidingD = false;
                    break;
                }
            }
        }
    }
}
