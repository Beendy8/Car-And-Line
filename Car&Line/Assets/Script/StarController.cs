using System;
using UnityEngine;

public class StarController : MonoBehaviour
{
    [SerializeField] private GameObject[] yesStar;
    public int[] star;

    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("StarController");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }
    private void Start()
    {
        if (PlayerPrefs.HasKey("stars"))
        {
            LoadStars();
        }
    }

    private void Update()
    {
        SaveStars();

    }

    public void SaveStars()
    {
        string s = " ";

        for (int i = 0; i < star.Length; i++)
        {
            s += star[i].ToString() + ",";
        }

        PlayerPrefs.SetString("stars", s);
    }

    public void LoadStars()
    {
        string[] s = PlayerPrefs.GetString("stars").Split(",");

        for (int i = 0; i < s.Length - 1; i++)
        {
            star[i] = Convert.ToInt32(s[i]);
        }
        for (int i = 0; i < star.Length; i++)
        {
            for (int k = 0; k < 3; k++)
            {
                if (star[i] >= k + 1)
                {
                    yesStar[k + 3 * i].SetActive(true);
                }
            }

        }
    }
}
