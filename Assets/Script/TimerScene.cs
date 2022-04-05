using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerScene : MonoBehaviour
{
    [SerializeField] private GameObject plate;
    public Reclam2 reclam;
    private int reclamCounter;

    void Start()
    {
       plate.SetActive(true);
       reclamCounter = PlayerPrefs.GetInt("reclamCounter");

       reclamCounter++;

        PlayerPrefs.SetInt("reclamCounter", reclamCounter);

        if (reclamCounter % 5 == 0)
        {
            reclam.showAd();
        }
        Debug.Log(reclamCounter);

        StartCoroutine(OutGame("Menu"));
    }
    IEnumerator OutGame(string sceneName)
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(sceneName);
    }
}
