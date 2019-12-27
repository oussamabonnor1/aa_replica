using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinBehaviour : MonoBehaviour
{
    public int speed;
    public Rigidbody2D rb;
    public bool shoot;

    // Update is called once per frame
    void Update()
    {
        if(shoot) rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.tag == "Rotator")
        {
            shoot = false;
            transform.parent = other.transform;
        }
    }
}
