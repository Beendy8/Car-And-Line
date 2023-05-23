using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish_first : Finish
{
    public static Finish_first instance;
    private void Awake()
    {
        instance= this;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            _first = true;
        }
        Complete();
    }
}
