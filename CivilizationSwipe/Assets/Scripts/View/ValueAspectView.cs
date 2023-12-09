using UnityEngine;
using UnityEngine.UI;

//Working with each individual aspect, displaying them and setting
//visible values
public class ValueAspectView : MonoBehaviour
{
    //The numerical value of the aspect and the rate of
    //change in height when solving
    private float Value;
    [SerializeField]static private float speed = 0.3f;

    //Depending on the name of the asset on which this script is based,
    //the value is set
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

    //I set the value of each aspect at startup
    private void Start()
    {
        Value = GetValueAspect(name);
        GetComponent<Image>().transform.localScale = new Vector3(1, Value / 100, 1);
    }

    //Each fixed frame I smoothly increase or decrease the aspect value
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
