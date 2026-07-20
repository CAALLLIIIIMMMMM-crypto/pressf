using UnityEngine;
using UnityEngine.SceneManagement;
public class Mainmenu : MonoBehaviour
{
    public void StartGameL()
    {
        SceneManager.LoadScene("cafe");  

    }

    public void exit()
    {
        Application.Quit();

    }

}
