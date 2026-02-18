using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScirpt : MonoBehaviour
{
    public TextMeshProUGUI CoinsText;

    private void Start()
    {
        CoinsText.text = $"Coins:{GameManager.instance.Coins}";
    }


    public void Play()
    {
        SceneManager.LoadScene("MainGameScene");
    }

    public void EnterUpgrades()
    {
        SceneManager.LoadScene("Upgrades");
    }
}
