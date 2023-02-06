using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gr : MonoBehaviour
{
    public GameObject cam;
    const float GravityConstant = 0.000000000067f;
    public GameObject[] Affectors;
    Rigidbody2D Body;
    float Dist;
    uint i;
    Vector2 radius;
    float velocity;
    Vector2 sp;
    Vector2 G;
    Vector2 t;
    void Start()
    {
        Body = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        cam.transform.position = new Vector3(transform.position.x, transform.position.y, -10);
        for (i = 0; i < Affectors.Length; ++i)
        {
            Dist = Vector2.Distance(transform.position, Affectors[i].transform.position);
            G = Affectors[i].transform.position - transform.position;
            Body.AddForce((G / Dist) * (Body.mass * Affectors[i].GetComponent<Rigidbody2D>().mass * GravityConstant) / (Dist * Dist + 1));
            var speed = Body.velocity.magnitude;
            sp = Body.velocity;
            velocity = Mathf.Sqrt(sp.magnitude * sp.magnitude + Dist * Dist);
            t = new Vector2(-1 * G.y, G.x);
            Body.AddForce(t.normalized * velocity);
        }
    }
}