using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnScore : MonoBehaviour {

    private AudioSource score;

     void Start()
    {
        score = GetComponent<AudioSource>();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            GameControl.instance.PacioScored();
            score.Play();
        }
    }
}
