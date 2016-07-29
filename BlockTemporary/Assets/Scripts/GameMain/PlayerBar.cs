using UnityEngine;
using System.Collections;

public class PlayerBar : MonoBehaviour {
    [SerializeField]
    public float accel;
    
    [SerializeField]
    private Vector3 pos;

    [SerializeField]
    private Vector3 WorldPointPos;
    
	// Use this for initialization
	void Start () {
        accel = 100.0f;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.3f, 0.0f, 0.0f);

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {

               
                Debug.Log("leftdown");
            }
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.Translate(0.3f, 0.0f, 0.0f);
        }
        
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            
            Debug.Log("rightdown");
        }

        //this.GetComponent<Rigidbody>().AddForce(
        //    transform.right * Input.GetAxisRaw("Horizontal") * accel,
        //    ForceMode.Impulse);

    }
}
