using UnityEngine;
using System.Collections;

public class ButtonEvent : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void PlayGame(){
		DataBean.getInstance ()._times = 0;
		Application.LoadLevel (Application.loadedLevel+1);
	}
	public void ExitGame(){

		Application.Quit ();
	}
}
