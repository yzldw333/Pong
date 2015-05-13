using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {
	public GameObject goject;
	static int jja=0;
	public test(){
		jja++;
		Debug.Log("test");
		Debug.Log (jja);
	}
	// Use this for initialization
	void Start () {
		StartCoroutine (Test());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	IEnumerator A()
	{
		while(true)
		{
			yield return new WaitForSeconds(1);
			Debug.Log ("aaaa");
		}
	}
	IEnumerator Test(){
		yield return new WaitForSeconds(9f);
		GameObject hh = GameObject.Instantiate (goject)as GameObject;


		Debug.Log (hh == null);
		hh.name = "newb";
		hh.GetComponent<DataBean> ()._times = 10000000;
		Debug.Log (hh.name);
	}
}
