using UnityEngine;
using System.Collections;

public class SlowDown : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		Debug .Log("Trigger");
		if(col.gameObject.name.Equals("Ball"))
		{
			DataBean.getInstance().slowScale = 0.5f;
			DataBean.getInstance().ifSlowed = true;
		}

	}
	void OnTriggerExit2D(Collider2D col)
	{
		if(col.gameObject.name.Equals("Ball"))
		{
			DataBean.getInstance().slowScale = 1;
			DataBean.getInstance().ifSlowed = false;
			float rmdValue = (float)Random.Range(-0.5f,0.5f);
			//p means the direction of the x is left or right;
			int p = col.gameObject.rigidbody2D.velocity.x>0?1:-1;
			col.gameObject.rigidbody2D.velocity = new Vector2(p*Mathf.Sqrt(1-rmdValue*rmdValue),rmdValue)*DataBean.getInstance()._velocity*DataBean.getInstance().AddScale;
		}

	}

}
