using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogueScript : MonoBehaviour {
    private float deletionMarker;
    private float lastScrollTime;
    private float expireDelta = 5f;
    private string fullText;
    private float scrollSpeed = 1f;
    private Text dialogText;
    private int curLinePos = 0;
    private int displayedCnt = 0;
    private const int linesPerPage = 5;
    private string[] lines;

	// Use this for initialization
	void Start () {
        deletionMarker = Time.time;
        lastScrollTime = Time.time;
        dialogText = gameObject.GetComponentInChildren<Text>();
    }

    public void SetText(string text)
    {
        fullText = text;
        lines = fullText.Split('\n');
    }

    public void SetScrollSpeed(float speed)
    {
        scrollSpeed = speed;
    }
	
	// Update is called once per frame
	void Update () {
        if(displayedCnt < fullText.Length )
        {
            // Only start the timer after the full text has been shown
            deletionMarker = Time.time;
        }
        else if( Time.time - deletionMarker > expireDelta )
        {
            DestroyObject(gameObject);
        }

        if(displayedCnt < fullText.Length && Time.time - lastScrollTime > scrollSpeed )
        {
            // Scroll the text
            string curText = fullText.Substring(0, ++displayedCnt);
            dialogText.text = curText;
            lastScrollTime = Time.time;
        }
	}
}
