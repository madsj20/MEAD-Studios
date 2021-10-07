using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;

    void Start()
    {
        currentHealth = 3;
    }

    
    // Update is called once per frame
    void TakeDamage (int amount)
    {
        currentHealth -= amount;

        if (currentHealth <= 0)
    }
}
