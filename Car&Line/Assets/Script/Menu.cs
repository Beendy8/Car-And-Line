using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    private const string levelName = "LvlScene";
    public void Play()
    {
        SceneManager.LoadScene(levelName);
    }
}
