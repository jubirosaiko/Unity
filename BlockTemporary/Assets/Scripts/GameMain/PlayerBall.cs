using UnityEngine;
using System.Collections;

public class PlayerBall : MonoBehaviour {

    private float ballSpeed = 20.0f;

	// Use this for initialization
	void Start () {

        this.GetComponent<Rigidbody>().AddForce(
            (transform.forward + transform.right) * ballSpeed,
            ForceMode.VelocityChange);
	}
	
	// Update is called once per frame
	void Update () {

       
      
	
	}
}
