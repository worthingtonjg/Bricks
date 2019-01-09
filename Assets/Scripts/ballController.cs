using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballController : MonoBehaviour
{
    public Rigidbody2D ball;

    public float maxSpeed = 25f;

    public bool fireOnAwake = false;

    // Start is called before the first frame update
    void Awake()
    {
        if(fireOnAwake)
        {
            ball.velocity = Random.onUnitSphere * 10f;
        }
    }

    void FixedUpdate()
    {
        ball.velocity = Vector3.ClampMagnitude(ball.velocity, maxSpeed);
    }
}
