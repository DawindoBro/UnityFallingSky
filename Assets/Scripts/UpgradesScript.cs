using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UpgradesScript : MonoBehaviour
{
    public TextMeshProUGUI MovementUpgradeText;
    public TextMeshProUGUI CoinsText;
    public TextMeshProUGUI CurrentSpeedText;
    private void Start()
    {
        UiUpdate();
    }

    public void Return()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void UiUpdate()
    {
        if (GameManager.instance != null)
        {
            MovementUpgradeText.text = $"{GameManager.instance.PlayerSpeedUpgradeCost.ToString()} Coins";
            CoinsText.text = $"Coins: {GameManager.instance.Coins}";
            CurrentSpeedText.text = $"Current Speed:{GameManager.instance.PlayerSpeed}";
        }
    }
    public void BuyMovementUpgrade()
    {
        if(GameManager.instance != null)
        {
            if(GameManager.instance.Coins >= GameManager.instance.PlayerSpeedUpgradeCost)
            {
                GameManager.instance.Coins -= GameManager.instance.PlayerSpeedUpgradeCost;
                GameManager.instance.PlayerSpeed += 1;
                GameManager.instance.PlayerSpeedUpgradeCost += GameManager.instance.PlayerSpeedUpgradeCostToAdd;
                Debug.Log("player speed: "+ GameManager.instance.PlayerSpeed);
                UiUpdate();
            }
        }
    }
    

}
