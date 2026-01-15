using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacio : MonoBehaviour
{
    public float upForce;
    private Animator anim;

    private AudioSource audioSource;
    
    public AudioClip death;

    private bool isDead = false;            
                
    private Rigidbody2D rb2d;               
    
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
       
        
    }

    void Update()
    {

        if (isDead == false)
        {

            if (Input.GetMouseButtonDown(0))
            {

                audioSource.Play();
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
        audioSource.clip = death;
        audioSource.Play();
        GetComponent<CircleCollider2D>().enabled = false;
        rb2d.AddForce(new Vector2(0, 400f));
        anim.SetTrigger("Death");
        
    }


}