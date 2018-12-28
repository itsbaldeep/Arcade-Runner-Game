using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

    public void PlayGame() {
        SceneManager.LoadScene(1);
    }

    public void Quit() {
        Application.Quit();
    }

}
