using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ActiveAnimation : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Animator targetAnimator; // Ссылка на компонент Animator, управляющий анимацией другого объекта
    public string parameterName; // Название переменной в аниматоре, значения которой будут меняться

    public bool enterValue; // Значение переменной при наведении курсора
    public bool exitValue; // Значение переменной при уходе курсора

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Устанавливаем значение переменной при наведении на кнопку
        targetAnimator.SetBool(parameterName, enterValue);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Устанавливаем значение переменной при уходе с кнопки
        targetAnimator.SetBool(parameterName, exitValue);
    }
}

