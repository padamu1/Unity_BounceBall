using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    new Rigidbody2D rigidbody2D;
    new Transform transform;
    float m_fSpeed;
    void Awake()
    {
        rigidbody2D = this.GetComponent<Rigidbody2D>();
        transform = this.GetComponent<Transform>();
        m_fSpeed = 500f;
    }

    void Start()
    {
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (rigidbody2D.velocity.x > -3f)
            {
                rigidbody2D.AddForce(new Vector2(-1f, 0f) * Time.deltaTime * m_fSpeed, ForceMode2D.Force);
            }
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (rigidbody2D.velocity.x < 3f)
            {
                rigidbody2D.AddForce(new Vector2(1f, 0f) * Time.deltaTime * m_fSpeed, ForceMode2D.Force);
            }
        }

        if (rigidbody2D.velocity.x > 0f)
        {
            rigidbody2D.AddForce(new Vector2(-0.5f, 0f) * Time.deltaTime * m_fSpeed, ForceMode2D.Force);
        }
        else if (rigidbody2D.velocity.x < 0f)
        {
            rigidbody2D.AddForce(new Vector2(0.5f, 0f) * Time.deltaTime * m_fSpeed, ForceMode2D.Force);
        }

        if(rigidbody2D.velocity.y < 0f)
        {
            rigidbody2D.AddForce(new Vector2(0f, -5f) * Time.deltaTime * m_fSpeed, ForceMode2D.Force);
        }
        else
        {
            rigidbody2D.AddForce(new Vector2(0f, -5f) * Time.deltaTime * m_fSpeed, ForceMode2D.Force);
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("MapObject"))
        {
            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, 0f);
            //Vector3 vector = Quaternion.AngleAxis(angle, Vector3.forward) * Vector3.right;
            rigidbody2D.AddForce(new Vector2(0f, 900f), ForceMode2D.Force);
        }
    }

    void PauseGame()
    {
        if (Time.timeScale == 1)
            Time.timeScale = 0;
    }

    void ResumeGame()
    {
        if (Time.timeScale == 0)
            Time.timeScale = 1;
    }
}
