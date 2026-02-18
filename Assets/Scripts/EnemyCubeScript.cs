using UnityEngine;

public class EnemyCubeScript : MonoBehaviour
{
    public int Damage = 20;
    
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            HealthMenagerScript health = other.GetComponent<HealthMenagerScript>();

            health.TakeDamage(Damage);
        }
        else if(other.CompareTag("Ground"))
        {
            
            ScoreMenager scoreMenager = FindObjectOfType<ScoreMenager>();
            if(scoreMenager != null)
            {
                scoreMenager.addScore();

            }
            Destroy(gameObject);
        }
    }
}
