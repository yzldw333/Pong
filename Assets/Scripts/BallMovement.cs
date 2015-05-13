using UnityEngine;
using System.Collections;
[RequireComponent(typeof(Rigidbody2D))]
public class BallMovement : MonoBehaviour {
	DataBean data;
	public float []v = new float[]{0,4,8f,10f};
	Vector2 dir;
	// Use this for initialization
	void PeriodCheck()
	{
		if(data._times > 40&&!data.ifAdded) 
		{
			data._period = 3;
		}
		else if(data._times>20&&!data.ifAdded)
		{
			data._period = 2;
		}
		else if(data._times>0&&!data.ifAdded)
		{
			data._period = 1;
		}
		data._velocity = v[data._period];
	}
	void RectifyVelocity()
	{
		//rectify the velocity'magtitude
		if(Mathf.Abs( gameObject.rigidbody2D.velocity.magnitude - data._velocity)>0.1f&&!data.ifSlowed&&!data.ifAdded)
		{
			Debug.Log(gameObject.rigidbody2D.velocity.magnitude+"  was rectified to  ");
			dir = gameObject.rigidbody2D.velocity.normalized;
			gameObject.rigidbody2D.velocity = dir*data._velocity;
			Debug.Log(gameObject.rigidbody2D.velocity.magnitude);
		}
		
		//rectify the direction of the velocity
		if(Mathf.Abs( gameObject.rigidbody2D.velocity.normalized.y)>0.7)
		{
			Debug.Log(gameObject.rigidbody2D.velocity+"  was rectified to  ");
			//plus or minus
			int negtive1 = gameObject.rigidbody2D.velocity.x>0?1:-1;
			int negtive2 = gameObject.rigidbody2D.velocity.y>0?1:-1;
			dir = new Vector2(Mathf.Sqrt(3)/2.0f*negtive1,0.5f*negtive2);
			gameObject.rigidbody2D.velocity = dir*data._velocity;
			Debug.Log(gameObject.rigidbody2D.velocity);
		}
		if(data.AddScale!=1||data.slowScale!=1)
		{
			changeVelocity();
		}
	}
	void Start () 
	{
		data = DataBean.getInstance ();
		data._velocity = v[1];
		data._period = 1;
		gameObject.rigidbody2D.velocity = new Vector2 ( data._velocity , 0 );
	}
	
	// Update is called once per frame
	void Update () 
	{

		PeriodCheck ();

		RectifyVelocity ();



	}
	void changeVelocity()
	{
		gameObject.rigidbody2D.velocity = gameObject.rigidbody2D.velocity.normalized * data._velocity * data.AddScale * data.slowScale;
	}
	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.name.Equals("player1")||col.gameObject.name.Equals("player2"))
		{
			AudioManagement.getInstance().getAudioSource().pitch = 1;
			AudioManagement.getInstance().PlayPong();
		}
		else if(col.gameObject.name.Equals("left")||col.gameObject.name.Equals("right"))
		{
			AudioManagement.getInstance().getAudioSource().pitch = 0.5f;
			AudioManagement.getInstance().PlayPong();
		}
	}
}
