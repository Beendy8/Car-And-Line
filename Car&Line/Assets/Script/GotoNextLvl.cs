using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoNextLvl : MonoBehaviour
{
    public void UnLockLevel()
    {
        int currentLvl1 = SceneManager.GetActiveScene().buildIndex;

        if (currentLvl1 >= PlayerPrefs.GetInt("levels", 1))
        {
            PlayerPrefs.SetInt("levels", currentLvl1);
            SceneManager.LoadScene(1);
        }
    }
}
