using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("LevelSelect");
    }
    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }
    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void Level1()
    {
        SceneManager.LoadScene("Map1");
    }
    public void Level2()
    {
        SceneManager.LoadScene("Map2");
    }
    public void Level3()
    {
        SceneManager.LoadScene("Map3");
    }
    public void Level4()
    {
        SceneManager.LoadScene("Map4");
    }
    public void Level5()
    {
        SceneManager.LoadScene("Map5");
    }
    public void Level6()
    {
        SceneManager.LoadScene("Map6");
    }
    public void Level7()
    {
        SceneManager.LoadScene("Map7");
    }
    public void Level8()
    {
        SceneManager.LoadScene("Map8");
    }
    public void Level9()
    {
        SceneManager.LoadScene("Map9");
    }
    public void Level10()
    {
        SceneManager.LoadScene("Map10");
    }
}
