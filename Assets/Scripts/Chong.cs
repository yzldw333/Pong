using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Chong : MonoBehaviour {
	public float max;
	float cur;
	public float addtime;
	public float destime;
	private static Chong instance1;
	private static Chong instance2;
	// UI adding
	public  bool isAdding= true;
	// Use this for initialization
	void Awake () {
		if(instance2!=null&&instance2!=this)
		{
			Destroy(gameObject);
		}
		else if(instance1!=null &&instance1!=this)
		{
			instance2 = this;
		}
		else
		{
			instance1 = this;
		}
	}

	public static Chong getInstance1()
	{
		return instance1;
	}
	public static Chong getInstance2()
	{
		return instance2;
	}
	public void ButtonDown()
	{

		if(getValue()>=0.005)
		{
			isAdding = false;
			GetComponent<Image>().fillAmount -= max/destime*Time.deltaTime;
		}
	}

	public void ButtonUp()
	{
			isAdding = true;
	}
	public float getValue()
	{
		return GetComponent<Image>().fillAmount;
	}
	// Update is called once per frame
	void Update () {
		if(isAdding)
		{
			GetComponent<Image>().fillAmount += max / addtime * Time.deltaTime;
		}
	}
}
