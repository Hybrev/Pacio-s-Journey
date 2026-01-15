using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goku : MonoBehaviour
{
    public float upForce;


    //Upward force of the "flap".
    private bool isDead = false;            //Has the player collided with a wall?

                   //Reference to the Animator component.
    private Rigidbody2D rb2d;               //Holds a reference to the Rigidbody2D component of the bird.

    void Start()
    {
        //Get reference to the Animator component attached to this GameObject.
        

        //Get and store a reference to the Rigidbody2D attached to this GameObject.
        rb2d = GetComponent<Rigidbody2D>();


    }

    void Update()
    {

        if (isDead == false)
        {

            if (Input.GetMouseButtonDown(0))
            {

                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(0, upForce));


            }
        }

    }

    void OnCollisionEnter2D(Collision2D other)
    {

        isDead = true;

        rb2d.velocity = Vector2.zero;
        GameControl.instance.PacioDied();
        


    }


}