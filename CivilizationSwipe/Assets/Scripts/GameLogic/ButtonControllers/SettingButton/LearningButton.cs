using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//The learning opening button
public class LearningButton : MonoBehaviour
{
    public GameObject setings;
    public void ButClick()
    {
        setings.SetActive(false);
        EscapeScript.active = false;
        GameObject.Find("CanvasLearning").GetComponent<LearningController>().StartLerning();
    }
}
