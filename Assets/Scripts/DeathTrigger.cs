using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Hero>() != null){
            collision.gameObject.transform.position = collision.gameObject.GetComponent<Hero>()._position;
        }
    }
}
