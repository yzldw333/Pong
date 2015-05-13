using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class LeftSkill : MonoBehaviour {
	private static LeftSkill instance;
	private bool isAnimating = false;
	private float from;
	private float tmp;
	public GameObject leftSlowDownTrigger;
	private LeftSkill()
	{
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(isAnimating)
		{
			instance.GetComponent<Image>().fillAmount = from + tmp;
			tmp += (float)(1.0/3/80);
			if(tmp > 1.0/3)
			{
				isAnimating = false;
			}
		}
	}
	public void UseSkill()
	{
		if(Mathf.Abs(instance.GetComponent<Image>().fillAmount-1)<0.05)
		{
			GetComponent<Image>().fillAmount = 0;
			leftSlowDownTrigger.SetActive(true);
		}

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
	}
	public static LeftSkill getInstance()
	{
		return instance;
	}
	public void skillAnimation()
	{
		isAnimating = true;
		from = instance.GetComponent<Image> ().fillAmount;
		tmp = 0;
	}
}
