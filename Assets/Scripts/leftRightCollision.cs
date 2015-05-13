using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class leftRightCollision : MonoBehaviour {
	DataBean data;
	public GameObject leftSkill;
	public GameObject rightSkill;
	// Use this for initialization
	void Start () 
	{
		data = DataBean.getInstance ();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.name.Equals("Ball"))
		{
			//left boundary means player2 got points
			if(gameObject.name.Equals("left"))
			{
				Debug.Log("left collision");
				data.AddPoints("player2");
				LeftSkill.getInstance().skillAnimation();
			}
			//right boundary means player1 got points
			if(gameObject.name.Equals("right"))
			{
				data.AddPoints("player1");
				RightSkill.getInstance().skillAnimation();
			}
			iTween.ColorTo (gameObject, iTween.Hash ("color", Color.red, "time", 0.4f));
			iTween.ColorTo (gameObject, iTween.Hash ("color", Color.white,"time",0.4f, "delay",0.4f));
		}

	}

}
