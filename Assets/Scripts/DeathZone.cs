using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public HealthMenagerScript HealthMenager;

    private void OnTriggerEnter(Collider other)
    {
        HealthMenager.Die();
    }
}
