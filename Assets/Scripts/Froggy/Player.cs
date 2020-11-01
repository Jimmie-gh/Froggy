using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour

{
    public float speed = 3.14f;
    public float jumpForce = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool isJump = Input.GetButtonDown("Jump");
        float froggyHAxis = Input.GetAxis("Horizontal");
        if (froggyHAxis != 0)
        {
            transform.position = new Vector3((transform.position.x + froggyHAxis * Time.deltaTime * speed), transform.position.y);
        }
        if(isJump)
        {
            Rigidbody2D rigid = GetComponent<Rigidbody2D>();
            rigid.AddForce(new Vector2(0, jumpForce));
        }
    }
}
