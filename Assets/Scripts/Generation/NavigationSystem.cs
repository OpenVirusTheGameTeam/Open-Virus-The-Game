using UnityEngine;
using UnityEngine.UI;
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

    //void OnGUI() {
    // If you're seeing errors update to the unity 4.6 beta for the new UI system.
    //GUI.Box(new Rect((Screen.width / 2) - 200, 0, 400, 100), current_directory);
    //}

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

    void Start() {
        string[] directory_spit = ReadFile("test.ovs");
        foreach (string e in directory_spit) {
            InterpretCommand(e);
        }
    }

    void Update() {
        DirDisplay.dirDisplay.text = DirDisplay.dirDisplayDefault.Replace("%DIR%", current_directory);
    }

    void decodeFile() {

    }
}
