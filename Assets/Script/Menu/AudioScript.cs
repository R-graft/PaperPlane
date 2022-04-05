using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    [SerializeField] private AudioSource Button;
    [SerializeField] private AudioClip clickFX;

    public void SoundClick()
    {
        Button.PlayOneShot(clickFX);
    }
}
