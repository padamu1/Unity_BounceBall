using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    new Rigidbody2D rigidbody2D;

    void Awake()
    {
        rigidbody2D = this.GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        rigidbody2D.AddForce(transform.up * -10f);
    }

    void Update()
    {
        
    }
}
