using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_New_Era : MonoBehaviour
{
    public GameObject prefab;
    public void Anim_Start_New_Era()
    {
        GameObject newPrefab = Instantiate(prefab, transform.position, transform.rotation);
        GameObject.Find("CanvasAnimation(Clone)").GetComponent<AnimationManager>().StartAnimations();
        Destroy(newPrefab, 3.2f);
    }
}
