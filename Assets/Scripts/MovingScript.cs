using UnityEngine;
using System.Collections;

public class MovingScript : MonoBehaviour {

    public float speed;
    public float rotationSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, translation, 0);
        transform.Rotate(0, 0, -rotation);
    }
}
