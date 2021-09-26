using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class Cube : ShapeMovement
{
    void Start()
    {
        
    }

    void Update()
    {
        Movement();
    }

    //POLYMORPHISM
    public override void Movement()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * 1);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * Time.deltaTime * 1);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime * 1);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * 1);
        }
    }
}
