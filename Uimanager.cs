using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Uimanager : MonoBehaviour
{
    // Start is called before the first frame update
    public void Ex()
    {
        SceneManager.LoadScene("exhibition");

    }
    public void exit()
    {
        Application.Quit();
    }
    public void showmenu()
    {
        SceneManager.LoadScene("menu");
    }
    public void phy()
    {
        SceneManager.LoadScene("phy");
    }
    public void che()
    {
        SceneManager.LoadScene("che");
    }
}
