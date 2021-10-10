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
}
