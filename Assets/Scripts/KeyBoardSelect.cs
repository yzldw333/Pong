using UnityEngine;
using System.Collections;

public class KeyBoardSelect : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void controllerChange(bool use)
	{
		if(use) 
		{
			DataBean.getInstance().controllWays = DataBean.getInstance().KEYBOARD;	
		}
		else
		{
			DataBean.getInstance().controllWays = DataBean.getInstance().CONTROLLER;	
		}
	}
}
