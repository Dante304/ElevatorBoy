using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPeasant : MonoBehaviour
{
    public GameObject peasent;

    void Start()
    {
       Spawn();
    }

    public void Spawn()
    {
        Instantiate(peasent);
    }
}
