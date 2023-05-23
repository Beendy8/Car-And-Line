using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] private GameObject canvasUIWin;
    protected bool _first;
    protected bool _second;

    private void Start()
    {
        _first = false;
        _second = false;
    }

    protected void Complete()
    {
        if (Finish_first.instance._first == true && Finish_second.instance._second == true)
        {
            canvasUIWin.SetActive(true);
            UITweenWin.instance.LevelSuccess();
            UITweenWin.instance.LevelComplete();
            UITweenWin.instance.StarsAnim();
            UITweenWin.instance.ActiveStars();
        }
    }
}
