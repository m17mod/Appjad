using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class myTrackableEventHandler : MonoBehaviour, ITrackableEventHandler {

    private TrackableBehaviour mTrackableBehaviour;

    public GameObject mainscript;

    void Start () {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }
    
    public void OnTrackableStateChanged(
                                    TrackableBehaviour.Status previousStatus,
                                    TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED)
        {
            Debug.Log("true");
			
			string text = gameObject.transform.GetChild(0).GetComponent<CheckChar>().checkChar; 

			//if ( text == "A") {
				Debug.Log(text);
				gameObject.transform.GetChild(0).GetComponent<CheckChar>().addChar();

				if(mainscript.GetComponent<mainScript>().quizChars[0] == null)
					mainscript.GetComponent<mainScript>().quizChars[0] = "text";
				else if(mainscript.GetComponent<mainScript>().quizChars[1] == null)
					mainscript.GetComponent<mainScript>().quizChars[1] = "text";
			//}
        }

        else
        {
            Debug.Log("false");
			gameObject.transform.GetChild(0).GetComponent<CheckChar>().removeChar();
        }
		
    }
}