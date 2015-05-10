using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class VarPool : MonoBehaviour {

	public static Dictionary<string, int> intDic = new Dictionary<string, int>();
	public static Dictionary<string, string> stringDic = new Dictionary<string, string>();
	public static Dictionary<string, bool> boolDic = new Dictionary<string, bool>();

	public enum modType {

		Delete = 0,
		Change = 1

	}

	//===================================================================== - Ints

	public static void pushInt(string key, int value){

		//Pushes an int into the pool

		intDic.Add(key, value);

	}

	public static int popInt(string key){

		//Pops an int from the pool

		return intDic[key];

	}

	public static void modifyInt(string key, modType mt, int newValue = 0){

		//There is probably a better way to do the optional paramater.
		//Maybe this should be split into two methods?

		//Modifies an int in the pool

		if(mt == modType.Delete){

			intDic.Remove(key);

		} else if (mt == modType.Change) {

			intDic[key] = newValue;

		}

	}

	//===================================================================== - Strings

	public static void pushString(string key, string value){
		
		//Pushes an string into the pool
		
		stringDic.Add(key, value);
		
	}
	
	public static string popString(string key){
		
		//Pops an int from the pool
		
		return stringDic[key];
		
	}
	
	public static void modifyString(string key, modType mt, string newValue = ""){

		//Modify a string in the pool

		if(mt == modType.Delete){
			
			stringDic.Remove(key);
			
		} else if (mt == modType.Change) {
			
			stringDic[key] = newValue;
			
		}
		
	}

	//===================================================================== - Bools

	public static void pushBool(string key, bool value){
		
		//Push a bool into the pool (how mean. he was a nice bool.)
		
		boolDic.Add(key, value);
		
	}
	
	public static bool popBool(string key){
		
		//Pops an bool from the pool
		
		return boolDic[key];
		
	}
	
	public static void modifyBool(string key, modType mt, bool newValue = false){
		
		//Modify a bool in the pool
		
		if(mt == modType.Delete){
			
			boolDic.Remove(key);
			
		} else if (mt == modType.Change) {
			
			boolDic[key] = newValue;
			
		}
		
	}

}
