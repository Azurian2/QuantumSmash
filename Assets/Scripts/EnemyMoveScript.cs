using UnityEngine;
using System.Collections;

public class EnemyMoveScript : MonoBehaviour {

    public float speed;
    public float rotationSpeed;
    public GameObject playerShip;
    public float initialDelay;
    

    // Use this for initialization
    void Start()
    {
        initialDelay = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > initialDelay)
        {
            playerShip = GameObject.Find("Ship");
            Vector3 targetDir = playerShip.transform.position - transform.position;
            Vector3 currentDir = transform.up;
            float angle = AngleSigned(targetDir, currentDir, transform.forward);
            transform.Rotate(0, 0, -angle * rotationSpeed * Time.deltaTime);
            transform.Translate(0, speed * Time.deltaTime, 0);
        }
    }

    public static float AngleSigned(Vector3 v1, Vector3 v2, Vector3 n)
    {
        return Mathf.Atan2(
            Vector3.Dot(n, Vector3.Cross(v1, v2)),
            Vector3.Dot(v1, v2)) * Mathf.Rad2Deg;
    }
}
