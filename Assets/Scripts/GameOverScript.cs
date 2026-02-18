using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public TextMeshProUGUI TextTmp;
   public void PlayAgain()
    {
        SceneManager.LoadScene("MainGameScene");

    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    private void Start()
    {
        TextTmp.text = $"Final Score: {ScoreMenager.finalScore}";
    }


}
