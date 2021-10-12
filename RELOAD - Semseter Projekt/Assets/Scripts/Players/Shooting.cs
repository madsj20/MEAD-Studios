using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public float playerNumber = 1;
    public Rigidbody2D bullet;
    public Transform FireTransform;
    public float launchForce = 20;

    private string fireButton;
    private bool fired = false;


    // Start is called before the first frame update
    void Start()
    {
        fireButton = "Fire" + playerNumber;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown(fireButton))
        {
            Fire();

        }
    }

    private void Fire()
    {
        fired = true;
        Rigidbody2D bulletInstance = Instantiate(bullet, FireTransform.position, FireTransform.rotation) as Rigidbody2D;
        bulletInstance.velocity = launchForce * FireTransform.up;
    }

}
