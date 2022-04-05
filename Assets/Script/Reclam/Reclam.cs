using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
public class Reclam : MonoBehaviour
{
    void Awake()
    {
        MobileAds.Initialize(initStatus =>{ });
    }

}
