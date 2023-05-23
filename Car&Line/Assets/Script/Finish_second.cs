using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish_second : Finish
{
    public static Finish_second instance;
    private void Awake()
    {
        instance = this;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            _second = true;
        }
        Complete();
    }
}
