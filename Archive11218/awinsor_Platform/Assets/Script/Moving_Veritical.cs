using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_Veritical : MonoBehaviour {

    public Vector3 velocity1 = new Vector3(0, .30f, 0);

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(velocity1);
        if (transform.localPosition.y > 6.22f)
        {
            velocity1 = new Vector3(0, -.30f, 0);
        }

        if (transform.localPosition.y < -6.99f)
        {
            velocity1 = new Vector3( 0, .30f, 0);

        }


    }
}
