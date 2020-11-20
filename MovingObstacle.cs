using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacle : MonoBehaviour
{

    public Rigidbody rb;


    public float forwardForce = 2000f;
    public float sidewaysForce = 0f;



    // Update is called once per frame
    void FixedUpdate()

    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        rb.AddForce(sidewaysForce, 0, 0 * Time.deltaTime);




    }



    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            forwardForce = 0f;
            sidewaysForce = 0f;

        }



    }





}

