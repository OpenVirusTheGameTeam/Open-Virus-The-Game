using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

public class NavigationSystem : MonoBehaviour {

	public GUISkin cdirSkin;
	public GUIStyle cdirStyle;

	public float cdirBoxWidth;
	public float cdirBoxHeight;

    private string current_directory = "C:\\";  

    void OnGUI() {
    
	
	GUI.skin = cdirSkin;
    GUI.Box(new Rect((Screen.width / 2) - (cdirBoxWidth / 2), 0, cdirBoxWidth, cdirBoxHeight), current_directory); //I really detest the new UI system. Can we plz use the old one?

    }

	public void SetDir(string dirName){

		current_directory = dirName;

	}

}