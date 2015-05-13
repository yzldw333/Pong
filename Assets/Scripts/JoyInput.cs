using UnityEngine;
using System.Collections;

public class JoyInput : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		JoyTest ();
		JoyTest2 ();
	}
	void JoyTest()
	{
		Debug.Log (Input.GetAxis ("firstY"));
		if(Input.GetKey(KeyCode.Joystick1Button0))
			Debug.Log("0"+"0");
		if(Input.GetKey(KeyCode.Joystick1Button1))
			Debug.Log("0"+"1");
		if(Input.GetKey(KeyCode.Joystick1Button2))
			Debug.Log("0"+"2");
		if(Input.GetKey(KeyCode.Joystick1Button3))
			Debug.Log("0"+"3");
		if(Input.GetKey(KeyCode.Joystick1Button4))
			Debug.Log("0"+"4");
		if(Input.GetKey(KeyCode.Joystick1Button5))
			Debug.Log("0"+"5");
		if(Input.GetKey(KeyCode.Joystick1Button6))
			Debug.Log("0"+"6");
		if(Input.GetKey(KeyCode.Joystick1Button7))
			Debug.Log("0"+"7");
		if(Input.GetKey(KeyCode.Joystick1Button8))
			Debug.Log("0"+"8");
		if(Input.GetKey(KeyCode.Joystick1Button9))
			Debug.Log("0"+"9");
	}
	void JoyTest2()
	{
		if(Input.GetKey(KeyCode.Joystick2Button0))
			Debug.Log("1"+"0");
		if(Input.GetKey(KeyCode.Joystick2Button1))
			Debug.Log("1"+"1");
		if(Input.GetKey(KeyCode.Joystick2Button2))
			Debug.Log("1"+"2");
		if(Input.GetKey(KeyCode.Joystick2Button3))
			Debug.Log("1"+"3");
		if(Input.GetKey(KeyCode.Joystick2Button4))
			Debug.Log("1"+"4");
		if(Input.GetKey(KeyCode.Joystick2Button5))
			Debug.Log("1"+"5");
		if(Input.GetKey(KeyCode.Joystick2Button6))
			Debug.Log("1"+"6");
		if(Input.GetKey(KeyCode.Joystick2Button7))
			Debug.Log("1"+"7");
		if(Input.GetKey(KeyCode.Joystick2Button8))
			Debug.Log("1"+"8");
		if(Input.GetKey(KeyCode.Joystick2Button9))
			Debug.Log("1"+"9");
	}
}
