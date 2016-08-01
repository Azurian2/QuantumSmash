using UnityEngine;
using System.Collections;

public class ScrollingBackground : MonoBehaviour {

    public float cameraDistOffset = 10;
    private GameObject background;
    private GameObject player;

    // Use this for initialization
    void Start()
    {
        background = GameObject.Find("background");
        player = GameObject.Find("Ship");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerInfo = player.transform.transform.position;
        background.transform.position = new Vector3(playerInfo.x, playerInfo.y, playerInfo.z - cameraDistOffset);
    }
}
