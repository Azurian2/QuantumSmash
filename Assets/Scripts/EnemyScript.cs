using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour
{
    public Rigidbody2D prefabBullet;
    public Rigidbody2D prefabCoin;
    public float shootForce = 5000;
    private float lastFired;
    public float fireRate = 1.0F;
    public int attackDamage = 10;
    public GameObject playerShip;
    public float curHealth;
    public GameObject bulletGo;
    public GameObject coin;

    // Use this for initialization
    void Start()
    {
        lastFired = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        var timeDelta = Time.time - lastFired;
        if (timeDelta > fireRate)
        {
            lastFired = Time.time;
            playerShip = GameObject.Find("Ship");
            var instanceBullet = Instantiate(prefabBullet, transform.position, Quaternion.identity) as Rigidbody2D;
            bulletGo = instanceBullet.gameObject;
            bulletGo.GetComponent<BulletScript>().source = gameObject;


            //var fireDirection = playerShip.transform.position - transform.position;
            var fireDirection = transform.up;
            fireDirection.Normalize();
            instanceBullet.GetComponent<Rigidbody2D>().AddForce(fireDirection * shootForce);
        }
    }

    void ApplyDamage(float damage)
    {
        curHealth -= damage;
        if (curHealth <= 0)
        {
            Death();
        }

    }
    void Death()
    {
        var coin = Instantiate(prefabCoin, transform.position, Quaternion.identity) as Rigidbody2D;
        var coinScript = coin.gameObject.GetComponent<CoinDrop>() as CoinDrop;
        coinScript.value = Random.Range(1, 11);
        Destroy(gameObject);
    }
}