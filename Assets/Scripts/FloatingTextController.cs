using UnityEngine;
using System.Collections;

public class FloatingTextController : MonoBehaviour {
    private static FloatingText popupText;
    private static GameObject canvas;

    public static void Initialize()
    {
        canvas = GameObject.FindWithTag("PlayerData");
        popupText = Resources.Load<FloatingText>("Prefabs2/PopupTextParent");
    }


    public static void CreateFloatingText(string text, Transform location)
    {
        FloatingText instance = Instantiate(popupText);
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(location.position);
        instance.transform.SetParent(canvas.transform, false);
        instance.transform.position = location.position + new Vector3(0,5,0);
        instance.SetText(text);
    }
}
