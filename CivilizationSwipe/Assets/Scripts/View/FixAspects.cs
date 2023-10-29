using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixAspects : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (MainStorage.Money > 100)
        {
            MainStorage.Money = 100;
        }
        if (MainStorage.Army > 100)
        {
            MainStorage.Army = 100;
        }
        if (MainStorage.Religion > 100)
        {
            MainStorage.Religion = 100;
        }
        if (MainStorage.People > 100)
        {
            MainStorage.People = 100;
        }
    }
}
