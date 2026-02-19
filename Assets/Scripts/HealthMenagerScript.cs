using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthMenagerScript : MonoBehaviour
{
    public int health = 100;
    public TextMeshProUGUI healthText;
    
            
    public void TakeDamage(int amount)
    {
        health -= amount;
        
        if(health <= 0)
        {
            Die();
        }
        UpdateUi();
    }
    
    public void Heal(int amount)
    {
        health += amount;
        UpdateUi();
    }
    void UpdateUi()
    {
        healthText.text = $"Health:{health.ToString()}";
    }
    public void Die()
    {
        Debug.Log("Boom");
        SceneManager.LoadScene("GameOver");
    }
}
