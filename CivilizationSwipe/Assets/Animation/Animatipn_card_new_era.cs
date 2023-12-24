using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    public GameObject[] objectsToAnimate;
    public GameObject GameObj;
    private int currentIndex = 0;

    IEnumerator PlayAnimationsWithDelay()
    {
        while (currentIndex < objectsToAnimate.Length)
        {
            yield return new WaitForSeconds(0.075f);  // Changed delay to 1 second
            PlayNextAnimation();     
        }
    }

    public void PlayNextAnimation()
    {
        if (currentIndex < objectsToAnimate.Length)
        {
            Animator animator = objectsToAnimate[currentIndex].GetComponent<Animator>();  // Fixed GetComponent syntax
            if (animator != null)
            {
                animator.Play("New_era");
            }
            currentIndex++;
        }
    }

    void Start()
    {
        // Removed extra PlayNextAnimation() call
        StartCoroutine(PlayAnimationsWithDelay());  // Changed method name to match IEnumerator name

    }

    public void StartAnimations()  // Added public method for button click
    {
        StartCoroutine(PlayAnimationsWithDelay());  // Call the animation coroutine
    }
}