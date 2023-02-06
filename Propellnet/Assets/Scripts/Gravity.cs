using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public GameObject cam;
    const float GravityConstant = 6.676f;
    public GameObject[] Affectors;
    Rigidbody2D Body;
    float Dist;
    Vector2 G;
    uint i;
    void Start() {
        Body = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        cam.transform.rotation = Quaternion.Euler(0, 0, 0);
        for (i = 0; i < Affectors.Length; ++i)
        {
            Dist = (Affectors[i].transform.position - transform.position).magnitude;
            G = Affectors[i].transform.position - transform.position;
            Body.AddForce((G * Body.mass * Affectors[i].GetComponent<Rigidbody2D>().mass * GravityConstant) / (Dist * Dist + 1));
        }
    }
}