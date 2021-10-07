using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private float rotationSpeed;
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



        /*if (movementDirection != Vector2.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, movementDirection);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }*/

    }
    private void FixedUpdate()
    {
        RotatePlayer();
    }

    private void RotatePlayer()
    {
        //rotatePlayer = Input.GetAxis("Rotate" + playerNumber);
        float rotation = -rotatePlayer * rotationSpeed;
        transform.Rotate(Vector3.forward * rotation);
    }

}
