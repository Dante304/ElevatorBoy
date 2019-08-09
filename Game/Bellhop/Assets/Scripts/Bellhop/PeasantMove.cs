using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PeasantMove : MonoBehaviour
{
    public float speed;
    public float waitTimeMove;
    public float waitTimeDestroy;
    public int sideToWalk;
    public GameObject speakCloud;
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
            GameObject.FindGameObjectWithTag("GameMechanics").GetComponentInChildren<PeasentCounter>().AddPeasent();
            StartCoroutine(WaitAndDestroy());
        }
    }

    IEnumerator WaitAndReturnSpeed(float tempSpeed)
    {
        float counter = 0;
        GameObject.FindGameObjectWithTag("GameMechanics").GetComponentInChildren<FloorRandomizer>().RandomizeFloor();
        int lastPeasent = GameObject.FindGameObjectWithTag("GameMechanics").GetComponentInChildren<ListOfPeasentInLift>().listOfPeasents.Count;
        float floorOfLastPeasent = GameObject.FindGameObjectWithTag("GameMechanics").GetComponentInChildren<ListOfPeasentInLift>().listOfPeasents[lastPeasent - 1].Floor;
        Debug.Log("Piętro: "+ floorOfLastPeasent);
        speakCloud.SetActive(true);
        GetComponentInChildren<TextMeshPro>().SetText("NA "+ floorOfLastPeasent + " PIĘTRO");
        
        while (counter < waitTimeMove)
        {
            counter += Time.deltaTime;
            yield return null;
        }
        speakCloud.SetActive(false);
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
