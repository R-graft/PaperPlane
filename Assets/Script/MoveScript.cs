using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScript : MonoBehaviour
{
    public static float speed = 0.15f;
    void FixedUpdate()
    {
        transform.Translate(-speed* 60 *Time.fixedDeltaTime, 0, 0);
    }
}
