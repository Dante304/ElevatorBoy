using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorRandomizer : MonoBehaviour
{
    public float minFloor;
    public float maxFloor;

    public void RandomizeFloor()
    {

        PeasentInLift peasent = this.gameObject.AddComponent<PeasentInLift>();
        peasent.Floor = Random.Range(minFloor, maxFloor);
        peasent.savePeasentInLift();
    }
}
