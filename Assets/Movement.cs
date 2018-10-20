using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rbody;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene("Unity Collition");
        }
        
    }
    //Lägg allt som har med fysik att göra här.
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rbody.AddForce(new Vector2(0f, 10f));
        }
        if (Input.GetKey(KeyCode.S))
        {
            rbody.AddForce(new Vector2(0f, -10f));
        }
        if (Input.GetKey(KeyCode.D))
        {
            rbody.AddForce(new Vector2(10f, 0f));
        }
        if (Input.GetKey(KeyCode.A))
        {
            rbody.AddForce(new Vector2(-10f, 0f));
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        SceneManager.LoadScene("Unity Collition");
    }
}
