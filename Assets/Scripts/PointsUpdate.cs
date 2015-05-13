using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PointsUpdate : MonoBehaviour {
	DataBean data;
	private Text label1;
	private Text label2;
	// Use this for initialization
	void Start () {
		data = DataBean.getInstance ();
		label1 = (Text)GetComponent<Text> ();
		label2 = (Text)GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(gameObject.name.Equals("PointLabel1"))
		{
			label1.text = ""+data.getPoints_left();
		}
		if(gameObject.name.Equals("PointLabel2"))
		{
			label2.text = ""+data.getPoints_right();
		}
	}
}
