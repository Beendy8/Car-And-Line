using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    int levelUnLock;
    [SerializeField] Button[] buttonsLvl;
    private void Start()
    {
        levelUnLock = PlayerPrefs.GetInt("levels", 1);

        for (int i = 0; i < buttonsLvl.Length; i++)
        {
            buttonsLvl[i].interactable = false;
        }
        for (int i = 0; i < levelUnLock; i++)
        {
            buttonsLvl[i].interactable = true;
        }
    }
    public void LoadLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }
}
