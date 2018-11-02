using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour {

    [SerializeField]
    float speed = 2f;

    Vector3 velocity = new Vector3(0,0,0);

	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {

        velocity = new Vector3(0, 0, 0);


       if (Input.GetKey(KeyCode.W))
       {
            if (transform.position.y < 1)
            {
                velocity += Vector3.up;
            }
            
       }

       if(Input.GetKey(KeyCode.A))
        {
            if (transform.position.x > -1.75)
            {
                velocity += Vector3.left;
            }
        }

       if(Input.GetKey(KeyCode.D))
        {
            if (transform.position.x < 1.75)
            {
                velocity += Vector3.right;
            }
        }

       if(Input.GetKey(KeyCode.S))
        {
            if (transform.position.y > -1)
            {
                velocity += Vector3.down;
            }

        }

        velocity.Normalize();
        

        transform.position += velocity * Time.deltaTime * speed;

	}
}
