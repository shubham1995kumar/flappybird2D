using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroudMusic : MonoBehaviour
{
    private static BackGroudMusic backGroudMusic;


    private void Awake()
    {
        if (backGroudMusic == null)
        {
            backGroudMusic = this;
            DontDestroyOnLoad(backGroudMusic);
        }
        else
        {
            Destroy(gameObject);

        }
    }
}
