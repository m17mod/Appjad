using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainScript : MonoBehaviour {

public string quizChar;
public string[] quizChars;

public Image box1;
public Sprite sprite1;
public Image box2;
public Sprite sprite2;

public GameObject correct;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//addChar();

		if(box1.sprite == null && box2.sprite != null){
			box1.GetComponent<Image>().sprite = box2.GetComponent<Image>().sprite;
			box2.GetComponent<Image>().sprite = null;
			
		}

		if(quizChars[0]+quizChars[1] == quizChar) {
			correct.SetActive(true);
		}

	}

	/*void addChar() {

		if(box1.sprite == null){
			Debug.Log("add to card 0");
			box1.GetComponent<Image>().sprite = sprite1;			
		} else if(box2.sprite == null){
			Debug.Log("add to card 1");
			box2.GetComponent<Image>().sprite = sprite2;	
		}
		
	}*/
}
