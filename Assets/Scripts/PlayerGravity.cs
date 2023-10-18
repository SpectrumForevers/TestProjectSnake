using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGravity : MonoBehaviour
{
    [SerializeField] GameAreaGravity areaGravity;
    private Transform playerTransform;
    Rigidbody rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Start()
    {
        rb.useGravity = false;
        rb.constraints = RigidbodyConstraints.FreezeRotation;

        playerTransform = transform;
    }
    private void FixedUpdate()
    {
        if (areaGravity)
        {
            areaGravity.Attract(playerTransform);
        }
    }
}
