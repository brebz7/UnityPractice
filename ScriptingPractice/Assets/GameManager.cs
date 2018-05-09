using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public float restartDelay = 1f;
    public GameObject levelCompletedUI;

    bool gameHasEnded = false;

    public void CompleteLevel()
    {
        levelCompletedUI.SetActive(true);
    }

	public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
        }

    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
