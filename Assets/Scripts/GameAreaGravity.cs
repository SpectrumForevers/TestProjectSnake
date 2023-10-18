using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAreaGravity : MonoBehaviour
{
    [SerializeField] float gravity = -12;
    public void Attract(Transform player)
    {
        Vector3 gravityUp = (player.transform.position - transform.position).normalized;
        Vector3 localUp = player.up;

        player.GetComponent<Rigidbody>().AddForce(gravityUp * gravity);

        Quaternion targetRotation = Quaternion.FromToRotation(localUp, gravityUp) * player.rotation;
        player.rotation = Quaternion.Slerp(player.rotation, targetRotation, 50f * Time.deltaTime);
    }
}
