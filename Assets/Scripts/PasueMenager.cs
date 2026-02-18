using UnityEngine;
using UnityEngine.SceneManagement;

public class PasueMenager : MonoBehaviour
{
    public GameObject PauseMenuParent;
    private bool IsPaused = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){

            if(IsPaused){Resume();}
            else{Pause();}
        }
    }
    public void Resume()
    {
        PauseMenuParent.SetActive(false);
        Time.timeScale = 1f;
        IsPaused = false;
    }
    public void Pause()
    {
        PauseMenuParent.SetActive(true);
        Time.timeScale = 0f;
        IsPaused = true;
    }
    public void QuitToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
}
