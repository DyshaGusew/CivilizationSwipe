using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Скрипт отвечающий за анимации карточек при выборе(наведении или нажатии) ЛЕВОГО решения
public class SwipeLeft : MonoBehaviour
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
        FindAnimation();
        if (animator != null)
        {
            animator.SetBool("Left", true);
        }
    }

    //Остановка анимации наклона
    public void FinishInclineAnimation()
    {
        FindAnimation();
        if (animator != null)
        {
            animator.SetBool("Left", false);
        }
    }

    //Запус увеличения слоя новосозданной карточки(тк под ней создается еще одна)
    public void SwipeLeftCard()
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
    public void SwipeLeftDelete()
    { 
        GameObject obj = GameObject.Find("Card");
        Animator Animarotlocal = obj.GetComponent<Animator>();

        // Меняем значение переменной DropLeft на true   
        Animarotlocal.SetBool("DropLeft", true);

        // Запускаем анимацию   
        StartCoroutine(WaitForAnimation(Animarotlocal, "DropLeft"));
    }

    //Задежка всех процессов, для проигрывания анимации
    private IEnumerator WaitForAnimation(Animator animator, string animationName)
    {
        animator.Play(animationName);

        // Задержка в пол секунды   
        yield return new WaitForSeconds(0.5f);

        // Удаляем объект после окончания анимации  
        Destroy(animator.gameObject);
    }
}
