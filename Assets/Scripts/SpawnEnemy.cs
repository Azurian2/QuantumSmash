using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour {

    public GameObject[] enemies;
    private Vector2 spawnpoint;
    public int enemycap;
    bool waitingForSpawn = false;

	void Update () {
        int curEnemyCnt = GameObject.FindGameObjectsWithTag("Enemy").Length;

        if (curEnemyCnt < enemycap && !waitingForSpawn)
        {
            waitingForSpawn = true;
            InvokeRepeating("spawnEnemy", 5, 10);
        }
	}
    void spawnEnemy ()
    {
        spawnpoint.x = Random.Range(-200,200);
        spawnpoint.y = Random.Range(-200,200);

        Instantiate(enemies [UnityEngine.Random.Range(0, enemies.Length)], spawnpoint, Quaternion.identity);
        CancelInvoke();
        waitingForSpawn = false;
    }
}
