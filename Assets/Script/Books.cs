using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Books : MonoBehaviour
{
    public GameObject[] book;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD

=======
>>>>>>> parent of 6b06ecc (third)
=======
>>>>>>> parent of 6b06ecc (third)
=======
>>>>>>> parent of 6b06ecc (third)
    public int aa;
    void Start()
    {
        
        StartCoroutine(Book());
    }
    IEnumerator Book()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.7f);
            int numberbook = Random.Range(0, 3);
            float position = Random.Range(-1.5f, 1.5f);
            GameObject newbook = Instantiate(book[numberbook], new Vector2(10, position), Quaternion.identity);
            Destroy(newbook,2);
        }
    }

}
