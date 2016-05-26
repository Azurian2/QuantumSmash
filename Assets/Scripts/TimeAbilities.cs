using UnityEngine;
using System.Collections;
public class TimeAbilities : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //shipGo = GameObject.Find("Ship");
	}
    public float timeScaler = 0.5f;
    public bool timeValue = true;
    //private GameObject shipGo;

	// Update is called once per frame
	void Update () {
	if(Input.GetKey(KeyCode.T) && Input.GetKey(KeyCode.Keypad1))
        {
            Time.timeScale = timeScaler;
        }
    if(Input.GetKeyUp(KeyCode.T) || Input.GetKeyUp(KeyCode.Alpha1))
        {
            Time.timeScale = 1f;
        }
    if(Input.GetKeyDown(KeyCode.G) && timeValue == true)
        {
            timeScaler = 0.5f;
            timeValue = false;
        }
        if (Input.GetKeyDown(KeyCode.G) && timeValue == false)
        {
            timeScaler = 0.25f;
            timeValue = true;
        }
       
    }
}
