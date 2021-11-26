using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

    private Rigidbody2D rb2d;
    private bool isDead;
    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        isDead = false;
    }
	
	// Update is called once per frame
	void Update () {
        isDead = Control.instance.getIsDead();
        if (isDead)
        {
            rb2d.velocity = Vector2.zero;
        }
        else
        {
            rb2d.velocity = new Vector2(-1.5f, 0f);
            if (transform.position.x < -GetComponent<BoxCollider2D>().size.x)
            {
                transform.position = new Vector2(20.42f, transform.position.y);
            }
        }
	}
}
