using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class PlayerMove : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] private DynamicJoystick joystick;
    private Vector3 moveDirection;
    Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        moveDirection = new Vector3(joystick.Horizontal * moveSpeed * Time.deltaTime, 0, joystick.Vertical * moveSpeed * Time.deltaTime);
        //Debug.Log(joystick.Horizontal);
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + transform.TransformDirection(moveDirection));
    }
}
