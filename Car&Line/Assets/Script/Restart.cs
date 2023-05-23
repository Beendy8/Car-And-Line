using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    [SerializeField] private AudioSource audioRestart;
    public void RestartLevel()
    {
        audioRestart.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }
}
