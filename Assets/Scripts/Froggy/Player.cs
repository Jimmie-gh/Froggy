using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour

{
    public float speed = 3.14f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float froggyHAxis = Input.GetAxis("Horizontal");
      if (froggyHAxis != 0)
        {
            transform.position = new Vector3((transform.position.x+ froggyHAxis*Time.deltaTime*speed), transform.position.y);
        }
    }
}
