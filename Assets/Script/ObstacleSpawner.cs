using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _book;

    [SerializeField] private GameObject _obstacle;

    private float position = 0;
    void Start()
    {
        StartCoroutine(Pencil());
        StartCoroutine(Book());
    }
    IEnumerator Pencil()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.07f);

            position = position + Random.Range(-0.9f, 0.9f);

            if (position > 2)
            {
                position = position - 1f;
            }

            if (position < -2)
            {
                position = position + 1f;
            }
            GameObject newprefab = Instantiate(_obstacle, new Vector2(12, position), Quaternion.identity);
        }
    }
   IEnumerator Book()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.8f);

            int numberbook = Random.Range(0, 3);

            float position = Random.Range(-2f, 2f);

            GameObject newbook = Instantiate(_book[numberbook], new Vector2(12, position), Quaternion.identity);
        }
    }
}
