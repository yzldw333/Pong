using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Sign : MonoBehaviour {
	RectTransform rectTransform;
	// Use this for initialization
	void Start () {
		rectTransform = GetComponent<RectTransform> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(DataBean.getInstance().getPoints_left() >= DataBean.getInstance().getPoints_right())
		{
			rectTransform.localPosition = new Vector3(-40,-20,0);
		}
		else 
		{
			rectTransform.localPosition = new Vector3(310,-20,0);
		}
	}
}
