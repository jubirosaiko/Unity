using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {

    [SerializeField]
    private int blockHp = 3;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Ball") {
            blockHp -= 1;


            
        }
        if (blockHp <= 0)
        {
            Destroy(this.gameObject);
            
        }
    }
}
