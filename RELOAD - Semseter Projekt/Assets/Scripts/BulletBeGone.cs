using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBeGone : MonoBehaviour
{
    public float maxLifeTime = 10f;
    // Start is called before the first frame update
    void Start()
    {
        //Destroys bullet after a given time
        Destroy(gameObject, maxLifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Collison events
        //Checks if barrier is hit
        if (other.gameObject.CompareTag("barrier"))
        {
            Debug.Log("Wall hit");
            Destroy(gameObject);
        }
        //Checks if player 1 is hit
        else if(other.gameObject.CompareTag("player1"))
        {
            Debug.Log("player 1 hit");
        }
        //Checks if player 2 is hit
        else if(other.gameObject.CompareTag("player2"))
        {
            Debug.Log("player 2 hit");
        }
    }

}
