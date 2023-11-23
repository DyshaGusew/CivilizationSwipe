using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Закрытие предупреждения о сбросе данных
public class CloseWarning : MonoBehaviour
{
    public GameObject warning;

    public void Close(GameObject warning)
    {
        warning.SetActive(false);
    }
}
