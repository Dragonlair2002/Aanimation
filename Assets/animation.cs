using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{
    public Animator anim;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("VadJagVill", true);
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            anim.SetBool("VadJagVill", false);
        }
    }
}
