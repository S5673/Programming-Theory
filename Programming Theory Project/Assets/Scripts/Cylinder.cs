using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : ShapeMovement
{
    private Rigidbody cylinderRb;
    // Start is called before the first frame update
    void Start()
    {
        cylinderRb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Jump();

    }

    public void Jump()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            cylinderRb.AddForce(Vector3.up * 10);
        }
    }
}
