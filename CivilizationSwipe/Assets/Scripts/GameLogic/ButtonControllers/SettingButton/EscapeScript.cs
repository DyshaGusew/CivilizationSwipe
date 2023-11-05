using UnityEngine;

public class EscapeScript : MonoBehaviour
{
    public GameObject canvasSetting;
    public GameObject warning;
    public static bool active = false;
    void Update()
    {

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
        }
    }
}