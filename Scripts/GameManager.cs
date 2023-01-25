using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool isGameEnded = false;
    public float restartTimeDelay = 3f;

    public void EndGame(string message)
    {
        if (isGameEnded == false)
        {
            isGameEnded = true;
            Debug.Log(message);
            Invoke("Restart", restartTimeDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
