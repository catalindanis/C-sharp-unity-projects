using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int movementSpeed;
    public Rigidbody2D player;
    private float horizontalMovement;
    private void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
    }
    private void FixedUpdate()
    {
        player.velocity = new Vector2(horizontalMovement*movementSpeed,player.velocity.y);
    }
}
