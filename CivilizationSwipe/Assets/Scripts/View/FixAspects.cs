using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixAspects : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (MainStorage.money > 100)
        {
            MainStorage.money = 100;
        }
        if (MainStorage.army > 100)
        {
            MainStorage.army = 100;
        }
        if (MainStorage.religion > 100)
        {
            MainStorage.religion = 100;
        }
        if (MainStorage.people > 100)
        {
            MainStorage.people = 100;
        }
    }
}
