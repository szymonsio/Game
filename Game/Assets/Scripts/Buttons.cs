using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {

	public void MenuButton()
    {
        SceneManager.LoadScene(0);
    }

    public void ExitButton()
    {
        Application.Quit();
    }

    public void AuthorsButton()
    {
        SceneManager.LoadScene(1);
    }

    public void CompendiumButton()
    {
        SceneManager.LoadScene(2);
    }

    public void GameButton()
    {
        SceneManager.LoadScene(3);
    }
}
   