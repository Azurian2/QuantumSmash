using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FiringScript : MonoBehaviour {
    public Rigidbody2D prefabBullet;
    public float shootForce = 5000;
    private float lastFired;
    public float fireRate;
    public int bullets = 500;
    public int attackDamage = 10;


	// Use this for initialization
	void Start () {
        lastFired = Time.time;
        //var playerData = GameObject.FindWithTag("PlayerData");
        var bulletCount = GameObject.Find("BulletCount");
        var bulletCountText = bulletCount.GetComponent<Text> ();
        bulletCountText.text = bullets.ToString() + " bullets";
    }
	
	// Update is called once per frame
	void Update () {
        var timeDelta = Time.time - lastFired;
        if (Input.GetButton("Fire1") && timeDelta > fireRate && bullets >= 1)
        {
            lastFired = Time.time;
            var instanceBullet = Instantiate(prefabBullet, transform.position, Quaternion.identity) as Rigidbody2D;
            var fireDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            fireDirection.Normalize();
            instanceBullet.GetComponent<Rigidbody2D>().AddForce(fireDirection * shootForce);
            bullets -= 1;
            //var playerData = GameObject.FindWithTag("PlayerData");
            var bulletCount = GameObject.Find("BulletCount");
            var bulletCountText = bulletCount.GetComponent<Text>();
            bulletCountText.text = bullets.ToString() + " bullets";
        }
    }
}
