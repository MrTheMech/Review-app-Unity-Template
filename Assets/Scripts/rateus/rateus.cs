using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rateus : MonoBehaviour
{
    public GameObject RateUsImage;
    public bool isClosed;
    public int openCountRateUs;
    private int isClosedSaved;

    private void Awake()
    {
        if (PlayerPrefs.HasKey("Closed"))
        {
            isClosedSaved = PlayerPrefs.GetInt("Closed");
        }
        else
        {
            PlayerPrefs.SetInt("Closed", 0);
        }
    }

    private void Start()
    {
        openCountRateUs = PlayerPrefs.GetInt("LaunchCount");        
    }
    private void Update()
    {

        if (isClosedSaved == 1) //reviewed or not
        {
            isClosed = true; 
        }

        if (isClosed) // closed or not
        {
            if (RateUsImage.activeInHierarchy) 
            {
                RateUsImage.SetActive(false);
            }
            ;
        }
        else
        {
            
            if (openCountRateUs >= 2)
            {
                RateUsImage.SetActive(true);
            }
        }
    }
    public void onClickClose()
    {
        isClosed = true;
    }
    public void rateUs()
    {
        onClickClose();
        Application.OpenURL("market://details?id=com.facebook.katana");
        PlayerPrefs.SetInt("Closed", 1);
        
    }
}
