using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckChar : MonoBehaviour {

	public string checkChar;
	
	public Sprite sprite;
	public Image box1;
	public Image box2;

	//public GameObject mainscript;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void addChar() {

		if(box1.sprite == null){
			Debug.Log("add to card 0");
			box1.GetComponent<Image>().sprite = sprite;
			//mainscript.GetComponent<mainScript>().quizChars[0] = ;
		} else if(box2.sprite == null){
			Debug.Log("add to card 1");
			box2.GetComponent<Image>().sprite = sprite;
		}
		
	}

	public void removeChar() {
		
		if(box1.sprite != null && box1.GetComponent<Image>().sprite == sprite ){
			Debug.Log("remove card 0");
			box1.GetComponent<Image>().sprite = null;
		} else if(box2.sprite != null && box2.GetComponent<Image>().sprite == sprite){
			Debug.Log("remove card 1");
			box2.GetComponent<Image>().sprite = null;
		}
		
	}

}
