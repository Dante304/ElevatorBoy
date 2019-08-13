using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeasantBehavior : MonoBehaviour
{
    public int sideToWalk;
    public float speed;
    public Rigidbody2D peasantRigidbody;
    public GameObject speakCloud;
    public float timeOfSpeakCloud;
    private Vector3 stopMove;
    private GameObject decisionButtons;
    private bool textShow;

    private void Start()
    {
        this.transform.position = GameObject.FindGameObjectWithTag("PeasantSpawn").transform.position;
        stopMove = GameObject.FindGameObjectWithTag("StopMove").transform.position;
        //decisionButtons = GameObject.FindGameObjectWithTag("DecisionButtons");
    }

    void Update()
    {
        if (this.transform.position.x < stopMove.x)
        {
            Move();
        }
        else if(!textShow)
        {
            ShowText();
        }

    }

    private void Move()
    {
        Vector2 tempVector = new Vector2(sideToWalk, 0);
        tempVector = tempVector.normalized * speed * Time.deltaTime;
        peasantRigidbody.MovePosition(peasantRigidbody.position + tempVector);
    }

    private void ShowText()
    {
        textShow = true;
        speakCloud.SetActive(true);
        StartCoroutine(TurnOffSpeakCloud());
    }

    IEnumerator TurnOffSpeakCloud()
    {
        float counter = 0;
        while (counter<timeOfSpeakCloud)
        {
            counter += Time.deltaTime;
            yield return null;
        }
       // decisionButtons.SetActive(true);
        speakCloud.SetActive(false);
    }



}
