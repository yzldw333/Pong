using UnityEngine;
using System.Collections;

public class DataBean : MonoBehaviour {

	public   readonly int KEYBOARD = 0;
	public   readonly int CONTROLLER = 1;
	private static DataBean instance;
	public float _velocity = 0;
	public int _period = 1;
	public float slowScale = 1;
	public float AddScale = 1;
	private int points_left=0;
	private int points_right=0;
	private int player1Combo = 0;
	private int player2Combo = 0;
	public int controllWays;
	public bool ifSlowed = false;
	public bool ifAdded = false;
	public float _times=0;
	public float controllerVelocity=10;
	private DataBean()
	{
		Debug.Log ("Databean created...");
	}
	// Use this for initialization
	
	// Update is called once per frame
	void Update () 
	{

	}
	void FixedUpdate()
	{
		_times += Time.fixedDeltaTime;
	}
	void Awake()
	{
		if (instance != null && instance != this)
		{
			Destroy(this.gameObject);
		}
		else
		{
			instance = this;
		}
		DontDestroyOnLoad(gameObject);
		controllWays = KEYBOARD;
	}
	public static DataBean getInstance()
	{
		return instance;
	}
	public void AddPoints(string name)
	{
		if(name.Equals("player1"))
		{
			points_left += 500+(player1Combo++)*500;
			player2Combo = 0;
		}
		if(name.Equals("player2"))
		{
			points_right += 500+(player2Combo++)*500;
			player1Combo = 0;
		}
	}
	public int getPoints_left()
	{
		return points_left;
	}
	public int getPoints_right()
	{
		return points_right;
	}
}
