using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb2d;

    bool grounded;

    [SerializeField]
    Transform GroundCheck;


    public GameObject broken;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.Find("GroundCheck").GetComponent<Ground>().grounded && grounded)
        {
            Instantiate(broken,rb2d.transform);
            grounded = false;
        }

        if (Input.GetKey("right")) {

            grounded = true;
            if (rb2d.angularVelocity <300f)
                rb2d.angularVelocity = -30f + rb2d.angularVelocity;
            else
                rb2d.angularVelocity = -30f;
        }
        if (Input.GetKey("left"))
            rb2d.angularVelocity = 30f + rb2d.angularVelocity;
    }
}
