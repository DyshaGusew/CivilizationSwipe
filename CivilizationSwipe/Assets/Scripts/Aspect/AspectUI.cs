using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;


public class AspectUI : MonoBehaviour
{
    //public GameObject Aspect;
    public float Value = 100;
    private Vector3 Position;
    public Image image;
    float top;
    void Start()
    {
        //Position = Aspect.transform.position;
        top = image.rectTransform.offsetMax.y;
        
    }

    void Update()
    {
        Vector2 offsetMax = image.rectTransform.offsetMax;
        offsetMax.y = top*(Value); // Установите нужное значение для "Top"
        image.rectTransform.offsetMax = offsetMax;
    }
}
