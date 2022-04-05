using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallChooseMode : MonoBehaviour
{
    [SerializeField] private GameObject Mode;

    public void CallMode()
    {
        Mode.SetActive(true);
    }
    private void Awake()
    {
        if (MoveScript.speed == 0)
        {
            Mode.SetActive(false);
        }
    }
}
