using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class InputController : MonoBehaviour {
	GameObject player1,player2;
	DataBean data;
	KeyCode chong1Key;
	KeyCode chong2Key;
	KeyCode yu1Key;
	KeyCode yu2Key;
	// Use this for initialization
	void Start () {
		player1 = GameObject.Find ("player1");
		player2 = GameObject.Find ("player2");
		data = DataBean.getInstance ();
		if(data.controllWays == data.KEYBOARD)
		{
			chong1Key = KeyCode.D;
			chong2Key = KeyCode.RightArrow;
			yu1Key    = KeyCode.A;
			yu2Key    = KeyCode.LeftArrow;
		}
		else if(data.controllWays == data.CONTROLLER)
		{
			chong1Key = KeyCode.Joystick1Button2;
			chong2Key = KeyCode.Joystick2Button2;
			yu1Key    = KeyCode.Joystick1Button1;
			yu2Key    = KeyCode.Joystick2Button1;
		}
	}
	void PlayerControll()
	{

		if(data.controllWays == data.KEYBOARD)
		{
			//player1's controller
			if(Input.GetKeyDown(KeyCode.W))
			{
				
				player1.rigidbody2D.velocity = new Vector2(0,data.controllerVelocity);
			}
			if(Input.GetKeyUp(KeyCode.W))
			{
				player1.rigidbody2D.velocity = new Vector2(0,0);
			}
			if(Input.GetKeyDown(KeyCode.S))
			{
				player1.rigidbody2D.velocity = new Vector2(0,-data.controllerVelocity);
			}
			if(Input.GetKeyUp(KeyCode.S))
			{
				player1.rigidbody2D.velocity = new Vector2(0,0);
			}
			//player2's controller
			if(Input.GetKeyDown(KeyCode.UpArrow))
			{
				player2.rigidbody2D.velocity = new Vector2(0,data.controllerVelocity);
			}
			if(Input.GetKeyUp(KeyCode.UpArrow))
			{
				player2.rigidbody2D.velocity = new Vector2(0,0);
			}
			if(Input.GetKeyDown(KeyCode.DownArrow))
			{
				player2.rigidbody2D.velocity = new Vector2(0,-data.controllerVelocity);
			}
			if(Input.GetKeyUp(KeyCode.DownArrow))
			{
				player2.rigidbody2D.velocity = new Vector2(0,0);
			}
		}
		else if(data.controllWays == data.CONTROLLER)
		{
			//player1's controller
			if(Input.GetAxis("firstY")>0)
			{
				
				player1.rigidbody2D.velocity = new Vector2(0,data.controllerVelocity);
			}
			if(Mathf.Abs(Input.GetAxis("firstY"))<=0.1)
			{
				player1.rigidbody2D.velocity = new Vector2(0,0);
			}
			if(Input.GetAxis("firstY")<0)
			{
				player1.rigidbody2D.velocity = new Vector2(0,-data.controllerVelocity);
			}
			if(Mathf.Abs(Input.GetAxis("firstY"))<=0.1)
			{
				player1.rigidbody2D.velocity = new Vector2(0,0);
			}
			//player2's controller
			if(Input.GetAxis("secondY")>0)
			{
				player2.rigidbody2D.velocity = new Vector2(0,data.controllerVelocity);
			}
			if(Mathf.Abs(Input.GetAxis("secondY"))<=0.1)
			{
				player2.rigidbody2D.velocity = new Vector2(0,0);
			}
			if(Input.GetAxis("secondY")<0)
			{
				player2.rigidbody2D.velocity = new Vector2(0,-data.controllerVelocity);
			}
			if(Mathf.Abs(Input.GetAxis("secondY"))<=0.1)
			{
				player2.rigidbody2D.velocity = new Vector2(0,0);
			}
		}
	}
	void YuSkillController()
	{
		if(Input.GetKey(yu1Key))
		{
			LeftSkill.getInstance().UseSkill();
		}
		if(Input.GetKey(yu2Key))
		{
			RightSkill.getInstance().UseSkill();
		}
	}
	void ChongSkillController()
	{
		if( Input.GetKey(chong1Key)||Input.GetKey(chong2Key) )
		{
			if(Input.GetKey(chong1Key))
			{
				Chong.getInstance1().ButtonDown();
				if(Chong.getInstance1().getValue()>=0.005)
				{
					DataBean.getInstance().ifAdded = true;
					DataBean.getInstance().AddScale = 2;
				}
				else
				{
					if(Input.GetKey(chong2Key)==false||(Input.GetKey(chong2Key)==true&&Chong.getInstance2().getValue()<=0.005))
					{
						DataBean.getInstance().ifAdded = false;
						DataBean.getInstance().AddScale = 1;
					}
				}
			}
			if(Input.GetKey(chong2Key))
			{
				Chong.getInstance2().ButtonDown();
				if(Chong.getInstance2().getValue()>=0.005)
				{
					DataBean.getInstance().ifAdded = true;
					DataBean.getInstance().AddScale = 2;
				}
				else 
				{
					if(Input.GetKey(chong1Key)==false||(Input.GetKey(chong1Key)==true&&Chong.getInstance1().getValue()<=0.005))
					{
						DataBean.getInstance().ifAdded = false;
						DataBean.getInstance().AddScale = 1;
					}
				}
			}


		}
		//both not use chong
		else if( Input.GetKeyUp(chong1Key) || Input.GetKeyUp(chong2Key) )
		{
			if(Input.GetKeyUp(chong1Key))
			{
				Chong.getInstance1().ButtonUp();
				if(Input.GetKey(chong2Key)==false)
				{
					DataBean.getInstance().ifAdded = false;
					DataBean.getInstance().AddScale = 1;
				}
			}
			if(Input.GetKeyUp(chong2Key))
			{
				Chong.getInstance2().ButtonUp();
				if(Input.GetKey(chong1Key)==false)
				{
					DataBean.getInstance().ifAdded = false;
					DataBean.getInstance().AddScale = 1;
				}
			}


		}
	}
	// Update is called once per frame
	void Update () {
		PlayerControll ();
		ChongSkillController ();
		YuSkillController ();
	}
}
