using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Master : MonoBehaviour
{

    public GameObject gameOverText;
    public static Master instance;
    public bool gameOver = false;
    public float scrollSpeed;
    public Text scoreText;
    private int score = 0;

    // Use this for initialization
    void Awake()
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
    void Update()
    {
        if (gameOver == true && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }

    public void PacioScored()
    {
        if (gameOver)
        {
            return;
        }
        score++;
        scoreText.text = "Score: " + score.ToString();

    }

    public void PacioDied()
    {

        gameOverText.SetActive(true);

        gameOver = true;

    }

}
