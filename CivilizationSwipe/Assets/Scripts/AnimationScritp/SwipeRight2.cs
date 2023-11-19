using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeRight2 : MonoBehaviour
{
    private Animator animator; // ссылка на компонент Animator

    private void FindAnimat()
    {
       // GameObject obj = GameObject.Find("NormalCard(Clone)"); // находим объект по имени
        //if (obj != null)
        //{
            animator = MainStorage.thisGameCard.GetComponent<Animator>(); // получаем компонент Animator
       // }
    }

    public void Startuem()
    {
        Finish();
        FindAnimat();
        if (animator != null)
        {
            animator.SetBool("Right", true); // изменение значения переменной в аниматоре
        }
    }

    public void Finish()
    {
        FindAnimat();
        if (animator != null)
        {
            animator.SetBool("Right", false); // изменение значения переменной в аниматоре
        }
    }

    public void SwipeRightCard()
    {
        // Находим объект по имени
        GameObject obj = GameObject.Find("NormalCard(Clone)");

        // Проверяем, найден ли объект
        if (obj != null)
        {
            obj.name = "Card";

            // Получить компонент SpriteRenderer
            SpriteRenderer spriteRenderer = obj.GetComponent<SpriteRenderer>();

            // Если компонент найден, установить order layer
            if (spriteRenderer != null)
            {
                spriteRenderer.sortingOrder = 10;
            }

            FindAnimat();
        }
    }
    public void SwipeRightDelete()
    {
        // Находим объект по имени   
        GameObject obj = GameObject.Find("Card");

        // Получаем компонент аниматора объекта   
        Animator Animarotlocal = obj.GetComponent<Animator>();

        // Меняем значение переменной DropLeft на true   
        Animarotlocal.SetBool("DropRight", true);

        // Запускаем анимацию   
        StartCoroutine(WaitForAnimation(Animarotlocal, "DropRight"));
    }

    private IEnumerator WaitForAnimation(Animator animator, string animationName)
    {
        animator.Play(animationName);

        // Задержка в пол секунды   
        yield return new WaitForSeconds(0.5f);

        // Удаляем объект после окончания анимации  
        Destroy(animator.gameObject);
    }
}