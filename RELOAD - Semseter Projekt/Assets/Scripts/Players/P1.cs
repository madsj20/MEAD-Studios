using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class P1 : MonoBehaviour
{
    private float _horizontalInput = 0;
    private float _verticalInput = 0;
    public int movementSpeed = 0;
    public int rotationSpeed = 0;

    Rigidbody2D rb2d;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        GetPlayerInput();

    }

    private void FixedUpdate()
    {

        RotatePlayer();
        MovePlayer();
    }


    private void GetPlayerInput()
    {
        _horizontalInput = Input.GetAxisRaw("Horizontal1");
        _verticalInput = Input.GetAxisRaw("Vertical1");
    }

    private void RotatePlayer()
    {
        float rotation = -_horizontalInput * rotationSpeed;
        transform.Rotate(Vector3.forward * rotation);
    }

    private void MovePlayer()
    {
        rb2d.velocity = transform.up * Mathf.Clamp01(_verticalInput) * movementSpeed;
        
    }
}