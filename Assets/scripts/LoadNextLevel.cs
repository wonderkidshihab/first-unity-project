using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadNextLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void loadNextLevel()
    {
        Debug.Log(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
