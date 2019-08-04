using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeasantMove : MonoBehaviour
{
    public float speed;
    public float waitTimeMove;
    public float waitTimeDestroy;
    public int sideToWalk;
    private Rigidbody2D peasantRigidbody;

    void Start()
    {
        peasantRigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector2 tempVector = new Vector2(sideToWalk, 0);
        tempVector = tempVector.normalized * speed * Time.deltaTime;
        peasantRigidbody.MovePosition(peasantRigidbody.position + tempVector);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bar")
        {
            float tempSpeed = speed;
            speed = 0;
           StartCoroutine(WaitAndReturnSpeed(tempSpeed));
        }

        if (collision.tag == "Door")
        {
            speed = 0;
            StartCoroutine(WaitAndDestroy());
        }
    }

    IEnumerator WaitAndReturnSpeed(float tempSpeed)
    {
        float counter = 0;
        while (counter < waitTimeMove)
        {
            counter += Time.deltaTime;
            yield return null;
        }

        speed = tempSpeed;
    }

    IEnumerator WaitAndDestroy()
    {
        float counter = 0;
        while (counter < waitTimeDestroy)
        {
            counter += Time.deltaTime;
            yield return null;
        }

        Destroy(this.gameObject);
    }
}
