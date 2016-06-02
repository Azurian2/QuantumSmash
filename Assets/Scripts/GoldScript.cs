using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GoldScript : MonoBehaviour {
    public int Gold;
    public float Goldk;
    public float Goldm;
    private Text goldCountText;
	// Use this for initialization
	void Start () {
        Goldk = Gold / 1000;
        Goldm = Gold / 1000000;
	}
	
	// Update is called once per frame
	void Update () {
	if(Gold >= 100000 && Gold < 1000000)
        {
            var goldCount = GameObject.Find("GoldCount");
            goldCountText = goldCount.GetComponent<Text>();
            goldCountText.text = Goldk.ToString() + "k coins";
        }
    if(Gold < 100000)
        {
            var goldCount = GameObject.Find("GoldCount");
            goldCountText = goldCount.GetComponent<Text>();
            goldCountText.text = Gold.ToString() + " coins";
        }
    if(Gold >= 1000000)
        {
            var goldCount = GameObject.Find("GoldCount");
            goldCountText = goldCount.GetComponent<Text>();
            goldCountText.text = Goldm.ToString() + "m coins";
        }
	}
}
