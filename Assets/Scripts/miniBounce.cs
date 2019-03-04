using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miniBounce : MonoBehaviour {

    public float sizer;
    public float jumper = 50f;
	// Use this for initialization
	void Start () {
        sizer = 1.1f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Hero>() != null)
        {
            collision.gameObject.transform.localScale *= sizer;
            collision.gameObject.GetComponent<Hero>().gravity += jumper;
            sizer += 0.1f;
            Destroy(gameObject);
        }
    }
}
