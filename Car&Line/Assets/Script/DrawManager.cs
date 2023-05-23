using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class DrawManager : MonoBehaviour
{
    private Camera _cam;
    [SerializeField] private Line _linePrefab;
    [SerializeField] private DrawManager drawManager;

    public const float RESOLUTION = 0.1f;

    private Line _currentLine;
    void Start()
    {
        _cam = Camera.main;
    }


    void Update()
    {
        Vector2 mousePos = _cam.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(1))
        {
            _currentLine = Instantiate(_linePrefab, mousePos, Quaternion.identity);
        }

        if (Input.GetMouseButton(1))
        {
            _currentLine.SetPosition(mousePos);
        }
    }
    public void Enable()
    {
        if (Input.GetMouseButtonUp(0))
        {
            drawManager.enabled = false;
        }
    }
}
