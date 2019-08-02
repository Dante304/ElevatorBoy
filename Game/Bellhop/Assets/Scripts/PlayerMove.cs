using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    private Rigidbody2D playerRigidbody;
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector2 tempVector = new Vector2(h, v);
        tempVector = tempVector.normalized * speed * Time.deltaTime;
        playerRigidbody.MovePosition(playerRigidbody.position + tempVector);
    }
}
