using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish_third : MonoBehaviour
{
    [SerializeField] private GameObject canvasUIWin;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            canvasUIWin.SetActive(true);
            UITweenWin.instance.LevelSuccess();
            UITweenWin.instance.LevelComplete();
            UITweenWin.instance.StarsAnim();
            UITweenWin.instance.ActiveStars();
        }
    }
}
