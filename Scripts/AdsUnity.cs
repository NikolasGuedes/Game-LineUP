using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
public class AdsUnity : MonoBehaviour
{
    public static AdsUnity instance;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void showAds()
    {
        if(Advertisement.IsReady("video"))
        {
            Advertisement.Show("video");
        }
    }



}
