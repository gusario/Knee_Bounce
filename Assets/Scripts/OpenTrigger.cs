using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTrigger : MonoBehaviour {

    public GameObject Box;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Hero>() != null){
            Destroy(Box);
            collision.gameObject.transform.position = collision.gameObject.GetComponent<Hero>()._position;
        }
    }
}
