using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
    [SerializeField] private GameObject crushPlane;
    [SerializeField] private GameObject sphere;
    [SerializeField] private GameObject plane;

    private bool up;

    private static Rigidbody2D sphereRigit;

    private float force;
    private float angleValue;
    void Start()
    {
        sphereRigit = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if(Input.touchCount > 0)
        //if (Input.GetKey(KeyCode.Space))
        {
            up = true;
        }
        else 
        {
            up = false; 
        }
        if (sphere.transform.position.y > 5f|| sphere.transform.position.y < -5f)
        {
            plane.SetActive(false);

            crushPlane.SetActive(true);

            crushPlane.transform.parent = null;

            MoveScript.speed = 0;
        }
    }
    void FixedUpdate()
    {
       angleValue = sphere.transform.rotation.eulerAngles.z;// угол самолета

       sphere.transform.position = new Vector2(-3f * Time.fixedDeltaTime * 60 , sphere.transform.position.y);
        
        if (up)
        {
            force += 0.25f;
            sphereRigit.velocity = Vector2.up * force;// подъем

            if (angleValue < 210)// вращение подъема
            {
                
                sphere.transform.Rotate(0.0f, 0.0f, 3f, Space.Self);//вращение подъема
            }
        }
        else
        {
            force = 2f;
            
            if (angleValue > 142)
            {
                sphere.transform.Rotate(0.0f, 0.0f, -0.8f, Space.World);// вращение падения
            }
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        plane.SetActive(false);

        crushPlane.SetActive(true);

        crushPlane.transform.parent = null;

        MoveScript.speed = 0;

       
    }
}
