using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

public class ScriptMan : MonoBehaviour {

	string[] dir;
	
	void Start () {

		string[] directory_spit = ReadFile("autoexec.ovs");

		foreach (string e in directory_spit) {
			InterpretCommand(e);
		}

	}

	void InterpretCommand(string line) {
		
		line = Regex.Replace(line, @"\r\n?|\n", string.Empty);
		
		if (line.StartsWith("echo")) { //Rem (in BASIC at least) is just a remark, so I thought it would be a good idea to change this to echo.
			string echo = line.Remove(0, 5);
			Debug.Log(echo);
		}
		
		if (line.StartsWith("rem")) {} //It's a remark. Don't do anything.
		
		if (line.StartsWith("startdir")) { //The starting directory.
			string directory = line.Remove(0, 9);
			Debug.Log("getting directory info...");
			dir = Directory.GetDirectories(directory);
			foreach (string d in dir) {
				Debug.Log(d);
			}
			Debug.Log(dir);
		}
		
		if (line.StartsWith ("playerspeed")) { //This command will eventually only work in "sandbox mode" to prevent cheating
			
			string speedToSet = line.Remove(0, 12);
			GameObject tempPilot = GameObject.FindGameObjectWithTag("Player");
			
			if(tempPilot.GetComponent<PilotMove>() != null){ //Just making sure
				
				tempPilot.GetComponent<PilotMove>().moveSpeedMultiplier = float.Parse(speedToSet);
				Debug.Log ("Set player speed to " + float.Parse(speedToSet));
				
			} else {
				
				Debug.LogError("Could not find player to set speed!"); //Should be impossible
				
			}
			
		}

		if (line.StartsWith("texturequality")) { //Higher number = less quality

			string qualityToSet = line.Remove(0, 15);
			QualitySettings.masterTextureLimit = int.Parse(qualityToSet);
			Debug.Log ("Set texture quality to " + qualityToSet);

		}

		if (line.StartsWith ("pixlightcount")) { //Higher number = more quality (and lag)

			string count = line.Remove(0, 14);
			QualitySettings.pixelLightCount = int.Parse(count);
			Debug.Log("Set pixel light count to " + int.Parse(count));


		}
		
	}

	string[] ReadFile(string fn) {
		var sr = File.OpenText (fn);
		string[] file = sr.ReadToEnd ().Split ("\n" [0]);
		sr.Close ();
		return file;
	}
}
