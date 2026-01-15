using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {

    public static GameControl instance;         //A reference to our game control script so we can access it statically.
    public Text scoreText;                      //A reference to the UI text component that displays the player's score.
    public GameObject gameOverText;
    //A reference to the object that displays the text which appears when the player dies.
    private AudioSource bkg;
    private int score = 0 ;                      //The player's score.
    public bool gameOver = false;               //Is the game over?
    public float scrollSpeed ;

    // Use this for initialization
    
    void Awake ()
    {
		if (instance == null)
        {
            instance = this;

        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
	}
	
   
	// Update is called once per frame
	void Update ()
    {
        if (gameOver == true && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }	
	}

    public void PacioScored()
    {
    
        if (gameOver)
            return;
       
        score++;
      
        scoreText.text = "Score: " + score.ToString();
    }


    public void PacioDied()
    {
        gameOverText.SetActive(true);

        gameOver = true;
        GetComponent<AudioSource>().enabled = false;

    }
    
}
