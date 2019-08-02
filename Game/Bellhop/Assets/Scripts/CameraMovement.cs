using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform playerPosition;

    private void Start()
    {
        GetComponent<Transform>().position = new Vector3(playerPosition.position.x, GetComponent<Transform>().position.y, GetComponent<Transform>().position.z);
    }

    void Update()
    {
        GetComponent<Transform>().position = new Vector3(playerPosition.position.x, GetComponent<Transform>().position.y, GetComponent<Transform>().position.z);
    }
}
