using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeLeft : MonoBehaviour
{
    private Animator animator; // ссылка на компонент Animator

    private void FindAnimat()
    {
       // GameObject obj = GameObject.Find("NormalCard(Clone)"); // находим объект по имени
       // if (obj != null)
        //{
            animator = MainStorage.thisGameCard.GetComponent<Animator>(); // получаем компонент Animator
      //  }
    }

    public void Startuem()
    {
        FindAnimat();
        if (animator != null)
        {
            animator.SetBool("Left", true); // изменение значения переменной в аниматоре
        }
    }

    public void Finish()
    {
        FindAnimat();
        if (animator != null)
        {
            animator.SetBool("Left", false); // изменение значения переменной в аниматоре
        }
    }
}
