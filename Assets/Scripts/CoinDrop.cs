using UnityEngine;
using System.Collections;

public class CoinDrop : MonoBehaviour {
    public int value;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ship")
        {
            other.gameObject.SendMessage("GiveCoins", value);
            Destroy(gameObject);
            //TODO: display message of how much gold was received
        }
    }

}
