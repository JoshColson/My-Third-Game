
using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {




    public float forwardForce = 200f;
    public float sidewaysForce = 50f;
    float maxSpeed = 30f;

    public Joystick joystick;

    public Rigidbody rb;

    private float boostDuration = 2.5f;
    private Coroutine boostCoroutine;

    private float slowDuration = 7.0f;
    private Coroutine slowCoroutine;



    private Vector3 lastPosition;
    private bool isMoving;
    private bool allowedToAccelerate;
    private float speed;
    private Vector3 horizontal;



    void Start()
    {
        rb = GetComponent<Rigidbody>();

        horizontal = Vector3.zero;
        lastPosition = transform.position;
        isMoving = false;
        allowedToAccelerate = true;



    }



    void FixedUpdate()
    {


        Vector3 v = transform.eulerAngles;

        {
            if (v.y > 130)
            {
                v.y = 130;
                //transform.eulerAngles = y;
            }
            else if (v.y < 50)
            {
                v.y = 50;
                //transform.eulerAngles = y;
            }
        }



        rb.constraints = RigidbodyConstraints.FreezeRotationX;
        rb.constraints = RigidbodyConstraints.FreezeRotationZ;



        var vel = GetComponent<Rigidbody>().velocity;

        if (transform.position != lastPosition)
        {
            isMoving = true;
        }

        if (transform.position == lastPosition)
        {
            isMoving = false;
        }

        if (isMoving)
        {
            speed = rb.velocity.magnitude;
            Debug.Log("Speed: " + speed);
            if (speed >= maxSpeed)
            {

                rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);
                allowedToAccelerate = false;
            }

            else
            {
                allowedToAccelerate = true;
            }
        }







        Vector3 horizontalVelocity = rb.velocity;
        horizontalVelocity = new Vector3(rb.velocity.x, 0, rb.velocity.z);






        if (allowedToAccelerate) 
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }

        if (Input.touchCount > 0)
        {
                var touch = Input.GetTouch(0);


                 rb.constraints = RigidbodyConstraints.None;

              if (touch.position.x < Screen.width / 2)
              {
                    Debug.Log("Left click");
                    rb.AddForce (-sidewaysForce, 0, maxSpeed * (2000* Time.deltaTime));

 
              }

              else if (touch.position.x > Screen.width / 2) 
              {
                    Debug.Log("Right click");
                    rb.AddForce(sidewaysForce, 0, maxSpeed * (2000 * Time.deltaTime));


              }


        }

          if (Input.touchCount < 1)
          {

            GetComponent<Rigidbody>().velocity = new Vector3(0,rb.velocity.y,maxSpeed);
            vel.x = 1f;
            vel.z *= maxSpeed;


          }

        lastPosition = transform.position;

    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Boost"))
        {

            boostCoroutine = StartCoroutine(Boost());
            Debug.Log("Boost Activated");
        }

        else
        {
            if (other.gameObject.CompareTag("Slow"))
            {
                slowCoroutine = StartCoroutine(Slow());
                Debug.Log("Go Slow Activated");
            }
            else
            {
                forwardForce = 200.0f;
            }
        }


    }


    IEnumerator Boost()
    {
        forwardForce = 11000.0f;
        maxSpeed = 60f;
        yield return new WaitForSeconds(boostDuration);
        Debug.Log("Boost Stopped");
        forwardForce = 200.0f;
        maxSpeed = 30f;
    }

    IEnumerator Slow()
    {
        forwardForce = 3000.0f;
        maxSpeed = 15f;
        yield return new WaitForSeconds(slowDuration);
        Debug.Log("Go Slow Stopped");
        forwardForce = 200.0f;
        maxSpeed = 30f;
    }





}
