using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

    static bool isDead = false;
    private Rigidbody2D br2d;
    private Animator anim;
    

    // Use this for initialization
    void Start () {
        br2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        isDead = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0) && !isDead)
        {
            br2d.velocity = Vector2.zero;
            br2d.AddForce(new Vector2(0, 200));
            anim.SetTrigger("Flap");
        }
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag != "Nest" && other.gameObject.tag != "Border")
        {
            isDead = true;
            anim.SetTrigger("Die");
            Control.instance.BirdDied();
        }
    }
}
