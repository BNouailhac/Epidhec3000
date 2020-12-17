using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class example : MonoBehaviour
{
    public float timer;
    public GameObject info;
    public GameObject to_1;
    public GameObject to_2;

    void Start()
    {
        timer = 0.0f;
        info = GameObject.Find("info");
        info.SetActive(true);
        to_1 = GameObject.Find("to_1");
        to_1.SetActive(true);
        to_2 = GameObject.Find("to_2");
        to_2.SetActive(true);
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 0.1f)
        {
            info.SetActive(true);
            to_1.SetActive(true);
            to_2.SetActive(true);
        }
        if (timer > 0.8f)
        {
            info.SetActive(false);
            to_1.SetActive(false);
            to_2.SetActive(false);
            timer = 0;
        }
    }
}