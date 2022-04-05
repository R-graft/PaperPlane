using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsChallenge : MonoBehaviour
{
    void FixedUpdate()
    {
        if (ModeChooser.isChallenge)
        {
            Time.timeScale += 0.01f * Time.deltaTime;
        }
    }
}
