using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool isEnded = false;

    public float restartDelay = 2f;
    public GameObject endUI;

    public void CompleteLevel() {
        endUI.SetActive(true);
    }

	public void EndGame() {
        if (!isEnded) {
            isEnded = true;
            Invoke("Restart", restartDelay);
        }
    }

    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
