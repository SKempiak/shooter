using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    float speed = 10f;
    Rigidbody body;
    public Rigidbody bullet;
    public float speed2 = 1000f;
    int spawnCounter = 0;
    // Use this for initialization
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = true;
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 vel = new Vector3(0, body.velocity.y);
        if (Input.GetKey(KeyCode.A))
        {
            vel += transform.right * -speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            vel += transform.right * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            vel += transform.forward * -speed;
        }
        if (Input.GetKey(KeyCode.W))
        {
            vel += transform.forward * speed;
        }
        if (Input.GetMouseButtonDown(0))
        {
            FireRocket();
        }

        body.velocity = vel;
        float rot = Input.GetAxis("Mouse X");
        transform.Rotate(0, rot, 0);
        if(spawnCounter>200){
            GameObject obj = (GameObject)Instantiate(Resources.Load("knight"), new Vector3(-36.686f, 67, -25.02054f), Quaternion.identity);
            spawnCounter = 0;
        }
        spawnCounter++;
    }
    void FireRocket()
    {
        Rigidbody rocketClone = (Rigidbody)Instantiate(bullet, transform.position+transform.forward*3, transform.rotation);
        rocketClone.velocity = transform.forward * speed2;
    }
}