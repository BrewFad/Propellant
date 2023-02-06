using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planetary : MonoBehaviour
{
    public Transform objectToOrbit;
    public GameObject rb;
    void Update()
    {
        float direction = (objectToOrbit.position - transform.position).sqrMagnitude;
        transform.RotateAround(objectToOrbit.position, Vector3.forward, rb.GetComponent<Rigidbody2D>().mass * GetComponent<Rigidbody2D>().mass / direction / direction * 40000f);
    }
}
