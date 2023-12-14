using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageManager : MonoBehaviour
{
    public int healthMeter = 0;
    public int healthMax = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Projectile"))
        {
            Destroy(other.gameObject);
            HitAnimal(1);
        }
    }

    public void HitAnimal(int healthAmount)
    {
        if (healthMeter < healthMax)
        {
            healthMeter += healthAmount;

            if (healthMeter >= healthMax)
            {
                
                transform.Rotate(0f, 180f, 0f);
            }
        }
    }
}
