using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth = 3;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;


    void Start()
 

        {
        maxHealth = 3;
        currentHealth = 3;
        }

    private void Update()
    {
        if (currentHealth == 2)

        {
            heart1.SetActive(false);
        }

        if (currentHealth == 1)

        {
            heart2.SetActive(false);
        }

        if (currentHealth == 0)

        {
            heart3.SetActive(false);
        }
    }



    // Update is called once per frame
    void TakeDamage (int amount)
    {
        currentHealth -= amount;

        if (currentHealth <= 0)
        { 
                //p� en eller anden m�de fort�l at spillet skal k�re void start igen
        }

        if (currentHealth == 2)

        {
            heart1.SetActive(false);
        }

        if (currentHealth == 1)

        {
            heart2.SetActive(false);
        }

        if (currentHealth == 0)

        {
            heart3.SetActive(false);
        }
    }
}
