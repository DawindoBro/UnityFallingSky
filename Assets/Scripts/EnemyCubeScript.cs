using UnityEngine;

public class EnemyCubeScript : MonoBehaviour
{
    public int Damage = 20;
    public int sizeDiff = 3;

    private void Start()
    {
        transform.localScale = new Vector3(Random.Range(1f, sizeDiff), Random.Range(1f, sizeDiff), Random.Range(1f, sizeDiff));
    }

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
