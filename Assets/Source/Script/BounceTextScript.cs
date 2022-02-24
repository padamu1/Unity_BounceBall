using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceTextScript : MonoBehaviour
{
    private float bounceSpeed = 0.4f;
    private RectTransform text;

    void Awake()
    {
        text = this.GetComponent< RectTransform>();
    }
    void Update()
    {
        if(text.localScale.x > 1.2f | text.localScale.x < 1f)
        {
            bounceSpeed *= -1;
        }


        text.localScale += (Vector3.one * Time.deltaTime * bounceSpeed);
    }
}
