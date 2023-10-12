using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public GameObject gameCard;
    void Start()
    {
        CardConstructor.CreatePlayCard(gameCard);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
