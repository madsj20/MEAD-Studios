using UnityEngine;

public class HealthWalls : MonoBehaviour
{
    public int maxHealthWalls;
    public int currentHealthWalls;

    void Start ()
    {
        currentHealthWalls = 10;
    }



    // Update is called once per frame
    void TakeDamage(int amount)
    {
        currentHealthWalls -= amount;

        if (currentHealthWalls <= 0)
        {
            //på en eller anden måde fortæl at spillet skal køre void start igen
        }
    }
}
