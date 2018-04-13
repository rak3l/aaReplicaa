using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour {

    #region properties
    private bool isPinned = false;

    public float speed = 20f;
    public Rigidbody2D rb;
    #endregion

    #region methods
    /*void Update()
    {
        if (!isPinned)
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
    }*/

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.up * speed, ForceMode2D.Impulse);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "Rotator")
        {
            transform.SetParent(col.transform);
            isPinned = true;
            rb.bodyType = RigidbodyType2D.Kinematic;
        }
        else
        {

        }
        
    }

    #endregion
}
