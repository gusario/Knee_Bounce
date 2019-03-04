using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hero : MonoBehaviour {

    public Material material;
    public float speed = 6.0f;
    public float gravity = 35f;
    public int trycounter;
    private Rigidbody body;

    public Vector3 _position;


	// Use this for sinitialization
    void Start () {
        body = GetComponent<Rigidbody>();
        _position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        float deltaX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float deltaZ = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        body.AddForce(deltaX, 0, deltaZ);


        if (Input.GetKeyDown(KeyCode.Space) &&
            (Physics.Raycast(transform.position, Vector3.down, 1.5f)))
        {
            body.AddForce(Vector3.up * gravity);
        }
        if (transform.position.y < -20)
        {
            transform.position = _position;
        }
        
	}

  
}
