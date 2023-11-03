using UnityEngine;

public class EscapeScript : MonoBehaviour
{
    public GameObject canvasSetting;
    public static bool active = false;
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (active == false)
            {
                active = true;
                canvasSetting.SetActive(active);
            }
            else if (active == true)
            {
                active = false;
                canvasSetting.SetActive(active);
            }
        }
    }
}