using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateCube : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        var eulers = transform.rotation.eulerAngles;
        transform.Rotate(new Vector3(0.0f,0.1f,0f));
        Debug.Log(eulers.x + ", " + eulers.y + ", " + eulers.z);
	}
}
