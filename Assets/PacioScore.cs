using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacioScore : MonoBehaviour
{
    private Animator taken;
    private AudioSource point;

     void Start()
    {
        point = GetComponent<AudioSource>();
        taken = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
           
            GameControl.instance.PacioScored();
            point.Play();
            taken.SetTrigger("taken");
            

        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == GetComponent<ColumnPool>())
        {
            Destroy(this.gameObject);

        }
    }
    
}


