using UnityEngine;

//Выход из игры по клавише
public class EscapeScript : MonoBehaviour
{
    public GameObject canvasSetting;
    public GameObject warning;
    public AudioSource Sound;
    //Переменная состояния выхода
    public static bool active = false;
    void Update()
    {
        //Проверка нажати я каждый кадр
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (active == false)
            {
                active = true;
                canvasSetting.SetActive(active);
                warning.SetActive(false);
            }
            else if (active == true)
            {
                active = false;
                canvasSetting.SetActive(active);
                warning.SetActive(false);
            }
            Sound.Play();
        }
    }
}