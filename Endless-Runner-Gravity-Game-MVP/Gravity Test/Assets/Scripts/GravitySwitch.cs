using UnityEngine;
using System.Collections;

public class GravitySwitch : MonoBehaviour
{
    public static bool regGravity;

    Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = gameObject.GetComponent<Rigidbody2D>();
        regGravity = true;
	}
	
	// Update is called once per frame
	void Update ()
    {
        rb.velocity = new Vector3(6f, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.S))
            regGravity = ! regGravity;
	}

    void FixedUpdate()
    {
        if (regGravity)
            rb.gravityScale = 1;
        else
            rb.gravityScale = -1;
    }
}
