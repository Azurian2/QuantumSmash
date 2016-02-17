#pragma strict

var prefabBullet: Transform;

var shootForce: float = 5000;
private var lastFired: float;
var fireRate: float;
var bullets = 500;
var attackDamage : int = 10;  

function Start () {
    lastFired = Time.time;
    var playerData = GameObject.FindWithTag("PlayerData");
    var bulletCount = playerData.Find("BulletCount");
    var bulletCountText : UI.Text = bulletCount.GetComponent.<UI.Text>();
    bulletCountText.text = bullets.ToString() + " bullets";
}

function Update () {
    var timeDelta = Time.time - lastFired;
    if(Input.GetButton("Fire1") && timeDelta > fireRate && bullets >= 1){
        lastFired = Time.time;
        var instanceBullet = Instantiate (prefabBullet, transform.position, Quaternion.identity);
        var fireDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        fireDirection.Normalize();
        instanceBullet.GetComponent.<Rigidbody2D>().AddForce(fireDirection*shootForce);
        bullets -= 1;
        var playerData = GameObject.FindWithTag("PlayerData");
        var bulletCount = playerData.Find("BulletCount");
        var bulletCountText : UI.Text = bulletCount.GetComponent.<UI.Text>();
        bulletCountText.text = bullets.ToString() + " bullets";
    }
}

