using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activation : MonoBehaviour {

    public GameObject rotator;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Hero>() != null)
        {
            rotator.SetActive(true);
        }
    }
}
