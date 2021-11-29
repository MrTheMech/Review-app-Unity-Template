using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class useropenchecker : MonoBehaviour
{
    void Awake()
    {
        IncrementLaunchCount();
    }

    void IncrementLaunchCount()
    {
        
        if (PlayerPrefs.HasKey("LaunchCount"))
        {
            int openCount = PlayerPrefs.GetInt("LaunchCount");
            openCount += 1;
            PlayerPrefs.SetInt("LaunchCount", openCount);
        }
        else
        {
            PlayerPrefs.SetInt("LaunchCount", 1);
        }

        PlayerPrefs.Save();
    }
}
