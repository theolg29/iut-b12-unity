using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayButton ()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void BackHome ()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void LeaderBoard ()
    {
        SceneManager.LoadScene("LeaderBoard");
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
