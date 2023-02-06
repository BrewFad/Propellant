using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float propellent = 2f;
    public float strenght = 0f;
    public float force = 1.2f;
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(transform.forward, strenght);
        if (propellent > 0)
        {
            if (Input.GetKey(KeyCode.UpArrow) == true)
            {
                propellent -= Time.deltaTime;
                GetComponent<Rigidbody2D>().AddForce(transform.up * force);
            }
            if (Input.GetKey(KeyCode.DownArrow) == true)
            {
                propellent -= Time.deltaTime;
                GetComponent<Rigidbody2D>().AddForce(transform.up * force * -1);
            }
            if (Input.GetKey(KeyCode.LeftArrow) == true) 
            {
                propellent -= Time.deltaTime / 10;
                strenght += 0.02f;
            }
            if (Input.GetKey(KeyCode.RightArrow) == true)
            {
                propellent -= Time.deltaTime / 10;
                strenght -= 0.02f;
            }
            if (Input.GetKey(KeyCode.RightArrow) == true && Input.GetKey(KeyCode.LeftShift))
            {
                propellent -= Time.deltaTime / 5;
                strenght -= 0.03f;
            }
            if (Input.GetKey(KeyCode.LeftArrow) == true && Input.GetKey(KeyCode.LeftShift))
            {
                propellent -= Time.deltaTime / 5;
                strenght += 0.03f;
            }
            if (Input.GetKey(KeyCode.UpArrow) == true && Input.GetKey(KeyCode.LeftShift))
            {
                propellent -= Time.deltaTime * 3;
                GetComponent<Rigidbody2D>().AddForce(transform.up * force * 2);
            }
            if (Input.GetKey(KeyCode.DownArrow) == true && Input.GetKey(KeyCode.LeftShift))
            {
                propellent -= Time.deltaTime * 3;
                GetComponent<Rigidbody2D>().AddForce(transform.up * force * -2);
            }
        }
    }
}
