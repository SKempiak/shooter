using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_script : MonoBehaviour {
    Vector3 forward = new Vector3(0,0,0);
	// Use this for initialization
    void SetForward(Vector3 vec){
        forward = vec;
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //this.transform.position += forward;
	}
}
