using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//small change

public class CubeBehavior : MonoBehaviour
{
    public Vector3 jump = new Vector3(0.0f, 1.0f, 0.0f);
    public Vector3 goForward = new Vector3(1.0f, 0.0f, 0.0f);
    public Vector3 goBack = new Vector3(-1.0f, 0.0f, 0.0f);
    public Vector3 goLeft = new Vector3(0.0f, 0.0f, -1.0f);
    public Vector3 goRight = new Vector3(0.0f, 0.0f, 1.0f);
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        jump = new Vector3(0.0f, 1.0f, 0.0f);
        goRight = new Vector3(1.0f, 0.0f, 0.0f);
        goLeft = new Vector3(-1.0f, 0.0f, 0.0f);
        goForward = new Vector3(0.0f, 0.0f, 1.0f);
        goBack = new Vector3(0.0f, 0.0f, -1.0f);
        speed = 10;
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody rb = this.gameObject.GetComponent<Rigidbody>();
        
        if(Input.GetKeyDown("space"))
        {
            rb.velocity = jump * speed;
        }

        if(Input.GetKeyDown("w"))
        {
            rb.velocity = goForward * speed;
        }

        if(Input.GetKeyDown("s"))
        {
            rb.velocity = goBack * speed;
        }

        if(Input.GetKeyDown("a"))
        {
            rb.velocity = goLeft * speed;
        }

        if(Input.GetKeyDown("d"))
        {
            rb.velocity = goRight * speed;
        }

    }
}
