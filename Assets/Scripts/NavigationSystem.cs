using UnityEngine;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;

public class NavigationSystem : MonoBehaviour {
 
	string[] dir;
	string current_directory = "C:\\";

	string[] ReadFile(string fn) {
		var sr = File.OpenText(fn);
		string[] file = sr.ReadToEnd().Split("\n"[0]);
		sr.Close();
		return file;
	}

	void OnGUI() {
		GUI.Box(new Rect((Screen.width/2)-200,0,400,100), current_directory);
	}

	void InterpretCommand(string line) {
		if (line.StartsWith("rem")) {
			string echo = line.Remove(0, 4);
			Debug.Log(echo);
		}
		if (line.StartsWith("startdir")) {
			string directory = line.Remove(0, 9);
			Debug.Log("getting directory info...");
			dir = Directory.GetDirectories(directory);
			foreach (string d in dir) {
				Debug.Log(d);
			}
			Debug.Log(dir);
		}
	}

	// Use this for initialization
	void Start () {
		string[] directory_spit = ReadFile("test.ovs");
		foreach (string e in directory_spit) 
		{
		      InterpretCommand(e);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	// Update is called once per frame
	void decodeFile () {
	
	}
}
