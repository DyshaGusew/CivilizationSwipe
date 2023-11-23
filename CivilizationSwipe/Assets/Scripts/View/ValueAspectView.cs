using UnityEngine;
using UnityEngine.UI;

//Работа с каждым отдельным аспектом их отображение и установка видимых значений
public class ValueAspectView : MonoBehaviour
{
    //Численное значение аспекта и скорость изменения высоты при решении
    private float Value;
    [SerializeField]static private float speed = 0.3f;

    //В зависимости от названия ассета на котором этот скрипт, устанавливается значение(Value)
    private float GetValueAspect(string name)
    {
        switch (name)
        {
            case "AtributMoney":
                return MainStorage.Money;
            case "AtributArmy":
                return MainStorage.Army;
            case "AtributReligion":
                return MainStorage.Religion;
            case "AtributPeople":
                return MainStorage.People;
            default:
                return 0;
        }
    }

    //Устанавливаю при запуске значение каждому аспекту
    private void Start()
    {
        Value = GetValueAspect(name);
        GetComponent<Image>().transform.localScale = new Vector3(1, Value / 100, 1);
    }

    //Каждый фиксированный кадр плавно увеличиваю или уменьшаю значение аспекта
    void FixedUpdate()
    {
        Value = GetValueAspect(name);
        if(GetComponent<Image>().transform.localScale.y < Value / 100)
        {
            GetComponent<Image>().transform.localScale += new Vector3(0, Time.deltaTime * speed, 0);
        }

        if (GetComponent<Image>().transform.localScale.y > (Value / 100))
        {
            GetComponent<Image>().transform.localScale -= new Vector3(0, Time.deltaTime * speed, 0);
        }

    }
}
