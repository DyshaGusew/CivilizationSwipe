using UnityEngine;

//Работа с изменением цвета аспектов
public class AspectGreenRed : MonoBehaviour
{
    //Базовые цвета аспектов и скорость изменения цвета
    private static readonly Color green = new Color(0, 0.7169812f, 0.06459286f);
    private static readonly Color red = new Color(0.9056604f, 0.09061617f, 0);
    private static readonly Color white = new Color(1f, 1f, 1f);
    private static readonly float speed = 0.03f;

    //Передаем параметры в метод и в зависимости от значения аспектов устанавливается цвет
    static public void AspectLightSol(int army, int money, int religion, int people)
    {
        if (army > 0)
            SetColor("AtributArmy", green);
        else if (army == 0)
            SetColor("AtributArmy", white);
        else
            SetColor("AtributArmy", red);

            
        if (money > 0)
            SetColor("AtributMoney", green);
        else if (money == 0)
            SetColor("AtributMoney", white);
        else
            SetColor("AtributMoney", red);
            

        if (religion > 0)
            SetColor("AtributReligion", green);
        else if (religion == 0)
            SetColor("AtributReligion", white);
        else
            SetColor("AtributReligion", red);
            


        if (people > 0)
            SetColor("AtributPeople", green);
        else if (people == 0)
            SetColor("AtributPeople", white);
        else
            SetColor("AtributPeople", red);      
    }

    //Устанавливаем указанный цвет указанному аспекту
    static private void SetColor(string nameAspect, Color color)
    {
        GameObject.Find(nameAspect).GetComponent<UnityEngine.UI.Image>().color = color;
    }

    //Когда значение цвета изменилось, мы плавно возвращаем его к белому
    private void FixedUpdate()
    {
        if (gameObject.GetComponent<UnityEngine.UI.Image>().color != white)
        {
            gameObject.GetComponent<UnityEngine.UI.Image>().color = Color.Lerp(gameObject.GetComponent<UnityEngine.UI.Image>().color, white, speed);
        }
    }
}

