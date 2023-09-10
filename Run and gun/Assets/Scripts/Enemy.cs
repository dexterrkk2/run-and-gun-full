using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float walkingForce;
    public Vector3 direction;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction *walkingForce *Time.deltaTime);
    }
    void OnCollisionEnter(Collision collision)
    {
        if(!(collision.collider.tag == "player") || !(collision.collider.tag == "ground"))
        {
            direction *= -1;
        }
    }
}
