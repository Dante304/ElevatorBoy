using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    private Rigidbody2D playerRigidbody;
    private PlayerAnimation playerAnimation;
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
        playerAnimation = GetComponentInChildren<PlayerAnimation>();
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        if (h != 0.0f || v != 0.0f)
        {
            playerAnimation.Walk(true, h, v);
        }
        else
        {
            playerAnimation.Walk(false, h, v);
        }
        Vector2 tempVector = new Vector2(h, v);
        tempVector = tempVector.normalized * speed * Time.deltaTime;
        playerRigidbody.MovePosition(playerRigidbody.position + tempVector);
    }
}
