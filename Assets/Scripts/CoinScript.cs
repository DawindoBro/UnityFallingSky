using System.Runtime.InteropServices;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public int CoinValue = 1;
    

    
    private void Start()
    {
        transform.rotation = Quaternion.Euler(0, 90, 90);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CoinMenager Coinmenager = FindFirstObjectByType<CoinMenager>();
            Coinmenager.addCoin(CoinValue);
            Destroy(gameObject);
        }
        else if(other.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
    }
}
