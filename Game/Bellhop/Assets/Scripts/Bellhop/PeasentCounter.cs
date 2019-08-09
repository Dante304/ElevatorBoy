using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PeasentCounter : MonoBehaviour
{
    public Text numberOfPeasent;

    public void AddPeasent()
    {
        int numberOfPeasentInt = Convert.ToInt32(numberOfPeasent.text);
        numberOfPeasentInt += 1;
        numberOfPeasent.text = Convert.ToString(numberOfPeasentInt);
    }
}
