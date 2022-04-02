using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{ 
    public SceneFader sceneFader;

    public GameObject GameOverUI;

    int virusDestroid;

    public void play()
    {
        sceneFader.FadeTo("Level 1");
    }

    public void quit()
    {
        Application.Quit();
    }
}
