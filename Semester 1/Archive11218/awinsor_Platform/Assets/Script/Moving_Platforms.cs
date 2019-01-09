using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_Platforms : MonoBehaviour {

    public Vector3 velocity = new Vector3(.15f, 0, 0);

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {

        transform.Translate(velocity);
        if (transform.localPosition.x > -4.36f)
        {
            velocity = new Vector3(-.15f, 0, 0);
        }

        if (transform.localPosition.x < -9.56f)
        {
            velocity = new Vector3(.15f, 0, 0);

        }



    }
}
