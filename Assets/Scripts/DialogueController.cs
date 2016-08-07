using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogueController {
    private static DialogueController instance;
    private GameObject canvas;
    private DialogueScript boxPrefab;

    public static DialogueController GetInstance()
    {
        if( instance == null)
        {
            instance = new DialogueController();
        }
        return instance;
    }

    public void ShowText(string text)
    {
        DialogueScript dialog = Object.Instantiate(boxPrefab);
        dialog.transform.SetParent(canvas.transform, false);
        dialog.SetText(text);
        dialog.SetScrollSpeed(0.5f);
    }

    private DialogueController()
    {
        canvas = GameObject.FindWithTag("DialogueCanvas");
        boxPrefab = Resources.Load<DialogueScript>("Prefabs2/DialogueBox");
    }
}
