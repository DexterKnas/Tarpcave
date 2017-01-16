using UnityEngine;
using System.Collections;

public class Player2 : MonoBehaviour 
{

    public float speed;//spelarens movement 
    bool grounded = true;//kollar ifall vi står på marken
    public float jump;//hoppets starkhet
    public bool isLookingRight = true;
    public Rigidbody2D rb;//Rigidbody2D

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D coll)//kollition med mark
    {
        if (coll.gameObject.tag == "Player") //kollar ifall vi står/kolliderar på mark
        {
            grounded = true;//sätter grounded till true
        }

        if (coll.gameObject.tag == "Ground") //kollar ifall vi står/kolliderar på mark
        {
            grounded = true;//sätter grounded till true
        }

    }
    // Update is called once per frame
    void Update()
    {
        //****************\\
        //----Movement----\\
        //****************\\
        // transform.Rotate(0, 0, 100000000);
        //---Jump---
        if (Input.GetKey(KeyCode.I) && grounded == true)//låter oss hoppa ifall vi trycker på space och grounded är true
        {
            rb.AddForce(Vector2.up * jump);//hopp!

            grounded = false;//sätter grounded till false så att det inte går att hoppa när man redan hoppat
        }
        if (Input.GetKey(KeyCode.X))
            transform.Rotate(0, 0, 1000);

        //---GroundSlam---
        //if (Input.GetKey(KeyCode.S))//låter oss hoppa ifall vi trycker på space och grounded är true
        //{
        //  rb.AddForce(Vector2.down * jump);//ground slam!
        //}

        //---venster och höger---
        float speedX = Input.GetAxis("Horizontal2");//andvänds för att flytta sig i x led
        float speedY = Input.GetAxis("Vertical");//

        rb.velocity = new Vector2(speedX * speed, rb.velocity.y);//låter oss röra sig venster och höger

        //roterar åt venster
        if (speedX < 0)
        {
            transform.localEulerAngles = new Vector3(0, 180, 0);
            isLookingRight = false;
        }
        //rotera år höger
        if (speedX > 0)
        {
            transform.localEulerAngles = new Vector3(0, 0, 0);
            isLookingRight = true;
        }
    }
}
