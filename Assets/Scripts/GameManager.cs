using UnityEditor.PackageManager;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;


    public int Coins = 0;
    public int PlayerSpeed = 5;

    //Upgrade Costs

    public int PlayerSpeedUpgradeCost =100;
    public int PlayerSpeedUpgradeCostToAdd = 25;


    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
