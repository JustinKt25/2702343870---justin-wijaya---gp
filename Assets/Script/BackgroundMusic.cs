using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    private static BackgroundMusic musicbackground;

    void Awake()
    {
        if(musicbackground == null )
        {
            musicbackground = this;
            DontDestroyOnLoad(musicbackground);
        }

        else
        {
            Destroy(gameObject);
        }
    }
}
