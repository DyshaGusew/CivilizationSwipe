using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class NewBehaviourScript : MonoBehaviour
{
    //Для денег
    public GameObject Aspect;
    public float Value = 100;
    private Vector3 Position;
    void Start()
    {
        Position = Aspect.transform.position;
    }

    void Update()
    {
        Aspect.transform.position = new Vector3(Position.x, Position.y+(Value/100), Position.z);
    }
}
