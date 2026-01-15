using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{

    public Animator animator;

    private int leveltoLoad;

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
        {
            FadetoLevel(1);
        }
	}

    public void FadetoLevel (int levelIndex)
    {
        leveltoLoad = levelIndex;
        animator.SetTrigger("fadeout");
    }

    public void OnFadeComplete ()
    {
        SceneManager.LoadScene(leveltoLoad);
    }
}
