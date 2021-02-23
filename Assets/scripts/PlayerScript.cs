using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody rb;
    public float force = 20;
    public float forwardForce = 900;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("I am Shihab");
        Debug.Log(SceneManager.GetActiveScene().buildIndex);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardForce * Time.deltaTime);
        //if (Input.GetKey("w")) { 
        //    rb.AddForce(0,  0,force * Time.deltaTime); 
        //}
        //if (Input.GetKey("s")) { 
        //    rb.AddForce(0, 0,-force * Time.deltaTime); 
        //}
        if (Input.GetKey("d")) { 
            rb.AddForce(force * Time.deltaTime,0, 0, ForceMode.VelocityChange); 
        }
        if (Input.GetKey("a")) { 
            rb.AddForce( -force * Time.deltaTime,0, 0, ForceMode.VelocityChange); 
        }

        if (transform.position.y < 0) {
            Debug.Log(transform.position.y);
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
