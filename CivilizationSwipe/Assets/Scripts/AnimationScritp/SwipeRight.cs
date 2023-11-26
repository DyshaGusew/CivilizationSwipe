using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Скрипт отвечающий за анимации карточек при выборе(наведении или нажатии) ПРАВОГО решения
public class SwipeRight : MonoBehaviour
{
    private Animator animator; // ссылка на компонент Animator, находится на самой карточке

    //Получаем компонент Animator у текущей карточки
    private void FindAnimation()
    {
        animator = MainStorage.thisGameCard.GetComponent<Animator>();
    }

    //Запуск анимации наклона
    public void StartInclineAnimation()
    {
        FinishInclineAnimation();
        FindAnimation();
        if (animator != null)
        {
            animator.SetBool("Right", true);
        }
    }

    //Остановка анимации наклона
    public void FinishInclineAnimation()
    {
        FindAnimation();
        if (animator != null)
        {
            animator.SetBool("Right", false);
        }
    }

    //Запус увеличения слоя текущей карточки(тк под ней создается еще одна)
    public void SwipeRightCard()
    {
        // Находим объект по имени
        GameObject obj = GameObject.Find("NormalCard(Clone)");

        // Проверяем, найден ли объект
        if (obj != null)
        {
            obj.name = "Card";
            SpriteRenderer spriteRenderer = obj.GetComponent<SpriteRenderer>();

            // Если компонент найден, установить слой повыше
            if (spriteRenderer != null)
            {
                spriteRenderer.sortingOrder = 10;
            }
        }
    }

    //Запуск анимации убирания верхней карточки
    public void SwipeRightDelete()
    {
        GameObject obj = GameObject.Find("Card");
        obj.tag = "Card"; // Установка тега объекту
        Animator Animarotlocal = obj.GetComponent<Animator>();
        // Запускаем анимацию     
        StartCoroutine(WaitForAnimation(Animarotlocal, "DropRight"));
    }

    //Задежка всех процессов, для проигрывания анимации
    private IEnumerator WaitForAnimation(Animator animator, string animationName)
    {
        animator.Play(animationName);
        // Задержка в пол секунды              
        yield return new WaitForSeconds(0.35f);

        // Удаляем все объекты с именем "Card" после окончания анимации     
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