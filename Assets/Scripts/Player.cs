using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Animation thisAnimation;
    private Rigidbody thisRigidbody = null;
    public float Force = 500f;
    void Start()
    {
        thisRigidbody = GetComponent<Rigidbody>();
        thisAnimation = GetComponent<Animation>();
        thisAnimation["Flap_Legacy"].speed = 3;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            thisAnimation.Play();
            thisRigidbody.AddForce(Vector3.up * Force);
        }
    }

    private void OnCollisionEnter(Collision Collision)
    {
        if(Collision.collider.tag == "Obstacle")
        {
            GameManager.thisManager.GameOver();
        }
    }
}
