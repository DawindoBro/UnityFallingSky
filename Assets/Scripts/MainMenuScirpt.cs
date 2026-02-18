using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScirpt : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("MainGameScene");
    }

    public void EnterUpgrades()
    {
        SceneManager.LoadScene("Upgrades");
    }
}
