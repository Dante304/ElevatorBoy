using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeasentInLift : MonoBehaviour
{

    public float Floor { get; set; }

    public void savePeasentInLift()
    {
        GameObject.FindGameObjectWithTag("GameMechanics").GetComponentInChildren<ListOfPeasentInLift>().listOfPeasents.Add(this);
    }

    public void savePeasentInLift(PeasentInLift peasent)
    {
        GameObject.FindGameObjectWithTag("GameMechanics").GetComponentInChildren<ListOfPeasentInLift>().listOfPeasents.Add(peasent);
    }


}
