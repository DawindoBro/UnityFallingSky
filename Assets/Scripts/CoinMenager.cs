using TMPro;
using UnityEngine;

public class CoinMenager : MonoBehaviour
{
    public int Coins = 0;
    public TextMeshProUGUI tmp;

    private void Start()
    {
        Coins = GameManager.instance.Coins;
    }
    public void addCoin(int amount)
    {
        Coins = Coins + 1;
        SaveCoins();
        UiUpdate();
    }
    public void SaveCoins()
    {
        GameManager.instance.Coins = Coins;
    }
    void UiUpdate()
    {
        tmp.text = $"Coins: {Coins}";
    }

}
