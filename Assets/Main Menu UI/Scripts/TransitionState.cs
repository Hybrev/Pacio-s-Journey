using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionState : MonoBehaviour
{

    public Animator animator;

    public GameObject TitleScreen;

    private int leveltoLoad;

    private bool isPlayed;

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
        {
            if (!isPlayed)
            {
                TitleScreen.SetActive(false);
                isPlayed = true;
            }
              
        }
	}

    public void FadetoLevel (int levelIndex)
    {
        //leveltoLoad = levelIndex;
       // animator.SetTrigger("fade_out");
    }

    public void OnFadeComplete ()
    {
        //SceneManager.LoadScene(leveltoLoad);
    }
    
}
