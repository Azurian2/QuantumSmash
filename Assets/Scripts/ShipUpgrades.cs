using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class ShipUpgrades : MonoBehaviour {
    private GameObject shipGo;
    private Text thrusterText;
    private Text RoThrusterText;
    private Text fireRateText;
    private string baseTextStr;
    private string baseTextStr2;
    private string baseTextStr3;
	// Use this for initialization
	void Start () {
        shipGo = GameObject.Find("Ship");
        thrusterText = GameObject.Find("ThrusterUpgraderButton/ThrusterUpgraderText").GetComponent<Text>();
        baseTextStr = thrusterText.text;
        RoThrusterText = GameObject.Find("RotationalThrusterUpgrader/RotationalThrusterUpgraderText").GetComponent<Text>();
        baseTextStr2 = RoThrusterText.text;
        fireRateText = GameObject.Find("FireRateUpgrader/FireRateUpgraderText").GetComponent<Text>();
        baseTextStr3 = fireRateText.text;
        UpdateThrusterText();
        UpgradeRoThrusterText();
        UpdateFireRateText();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void AddThrusterUpgrade()
    {
        var tmp = shipGo.GetComponent<MovingScript>();
        if(tmp.speed < 250)
        {
            tmp.speed += 10;
            UpdateThrusterText();
        }
    }
    
    public void AddRoThrustersUpgrade()
    {
        var tmp = shipGo.GetComponent<MovingScript>();
        if(tmp.rotationSpeed < 500)
        tmp.rotationSpeed += 10;
        UpgradeRoThrusterText();
    }
    public void AddFireRateUpgrade()
    {
        var tmp2 = shipGo.GetComponent<FiringScript>();
        if(tmp2.fireRate > 0.105)
        {
            tmp2.fireRate -= 0.05F;
            UpdateFireRateText();
        }
    }
    private void UpdateThrusterText()
    {
        var tmp = shipGo.GetComponent<MovingScript>();
        thrusterText.text = baseTextStr + "\nCurrent Speed: " + tmp.speed;
    }
    private void UpgradeRoThrusterText()
    {
        var tmp = shipGo.GetComponent<MovingScript>();
        RoThrusterText.text = baseTextStr2 + "\nCurrent Speed: " + tmp.rotationSpeed;
    }
    private void UpdateFireRateText()
    {
        var tmp2 = shipGo.GetComponent<FiringScript>();
        fireRateText.text = baseTextStr3 + "\nCurrent Rate: " + (Math.Round(tmp2.fireRate,2)) + " seconds per bullet";
    }
}
