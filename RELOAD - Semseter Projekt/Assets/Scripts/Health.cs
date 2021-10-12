using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth = 3;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public GameObject bullet;


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
                //på en eller anden måde fortæl at spillet skal køre void start igen
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
    private void OnTriggerEnter2D(Collider2D bullet)
    {
        Debug.Log("Player " + gameObject.GetComponent<Movement>().playerNumber + " lost health");
        currentHealth -= 1;
    }
}
