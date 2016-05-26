using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {
    public GameObject source;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (source.tag != "Enemy" && other.gameObject.tag == "Enemy")
        {
            other.gameObject.SendMessage("ApplyDamage", 10);
            Destroy(gameObject);
        }
    }
}
