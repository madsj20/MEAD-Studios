using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2 : MonoBehaviour
{
    [SerializeField]
    private int speed = 0;

    [SerializeField]
    private float rotationSpeed = 0;
    public float playerNumber = 2;
    private float horizontalInput;
    private float verticalInput;
    private float rotatePlayer;

    void Update()
    {
        horizontalInput = Input.GetAxis("Vertical" + playerNumber);
        verticalInput = Input.GetAxis("Horizontal" + playerNumber);
        rotatePlayer = Input.GetAxis("Rotate" + playerNumber);

        Vector2 movementDirection = new Vector2(horizontalInput, verticalInput);
        float inputMagnitude = Mathf.Clamp01(movementDirection.magnitude);
        movementDirection.Normalize();

        transform.Translate(movementDirection * speed * inputMagnitude * Time.deltaTime, Space.World);
        RotatePlayer();


    }
    private void FixedUpdate()
    {
        
    }

    private void RotatePlayer()
    {
        //rotatePlayer = Input.GetAxis("Rotate" + playerNumber);
        float rotation = -rotatePlayer * rotationSpeed;
        transform.Rotate(Vector3.forward * rotation * Time.deltaTime);
        
    }

}
