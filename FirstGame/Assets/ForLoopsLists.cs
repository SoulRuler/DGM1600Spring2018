using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForLoopsLists : MonoBehaviour {

 	public TheIncreadables TheIncreadables;
 	public Text AddMember;

	//public string [] PlayerName;
	//public List<string> PlayerNameList;

	
	void OnMouseDown() {

		TheIncreadables.FamilyList.Add(AddMember.text);
	
	}

}


//lists are like arrays, they are harder, but they are better for gameplay

//list use system.collections.generic

//public string[] PlayerName;
//public List<string> PlayerNameList;

//Lists help you with collections 
//Arrays are good for things you alrady have of one type and you need a lot of. 

//Lists have an add function

//Im a little confused but we'll see

//Unity engine.UI is important