using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DirDisplay : MonoBehaviour {

    public static Text dirDisplay;
    public static string dirDisplayDefault;

    void Start() {
        dirDisplay = GetComponent<Text>();
        dirDisplayDefault = dirDisplay.text;
    }

}
