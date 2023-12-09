using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//The script responsible for the animation of the cards when selected (hovering or clicking) THE LEFT-HAND solution
public class SwipeLeft : MonoBehaviour
{
    private Animator animator; //The link to the Animator component is located on the card itself

    //Getting the Animator component from the current card
    private void FindAnimation()
    {
        animator = MainStorage.thisGameCard.GetComponent<Animator>();
    }

    //Starting the tilt animation
    public void StartInclineAnimation()
    {
        FindAnimation();
        if (animator != null)
        {
            animator.SetBool("Left", true);
        }
    }

    //Stoping the tilt animation
    public void FinishInclineAnimation()
    {
        FindAnimation();
        if (animator != null)
        {
            animator.SetBool("Left", false);
        }
    }

    //The start of increasing the layer of the newly created card (because another one is being created under it)
    public void SwipeLeftCard()
    {
        // Finding an object by name
        GameObject obj = GameObject.Find("NormalCard(Clone)");

        // Checking if the object has been found
        if (obj != null)
        {
            obj.name = "Card";
            SpriteRenderer spriteRenderer = obj.GetComponent<SpriteRenderer>();

            // If the component is found, set the layer higher
            if (spriteRenderer != null)
            {
                spriteRenderer.sortingOrder = 10;
            }
        }
    }
    public void SwipeLeftDelete()
    {
        GameObject obj = GameObject.Find("Card");
        obj.tag = "Card"; // Setting a tag for an object
        Animator Animarotlocal = obj.GetComponent<Animator>();
        //  Starting the animation
        StartCoroutine(WaitForAnimation(Animarotlocal, "DropLeft"));
    }

    //Delay of all processes to play the animation
    private IEnumerator WaitForAnimation(Animator animator, string animationName)
    {
        animator.Play(animationName);
        //Half a second delay       
        yield return new WaitForSeconds(0.35f);

        //We delete all objects named "Card" after the end of the animation     
        GameObject[] cards = GameObject.FindGameObjectsWithTag("Card");
        foreach (GameObject card in cards)
        {
            if (card.name == "Card")
            {
                Destroy(card);
            }
        }
    }
}
