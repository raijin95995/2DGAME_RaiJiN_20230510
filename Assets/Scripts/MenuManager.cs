using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MenuManager : MonoBehaviour
{

    

    public void StartGame()
    {
        SceneManager.LoadScene("01");
    }

    public void ExitGame()
    {

        Application.Quit();

    }

 
}
