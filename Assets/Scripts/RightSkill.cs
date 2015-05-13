using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class RightSkill : MonoBehaviour {
	private static RightSkill instance;
	private bool isAnimating = false;
	private float from;
	private float tmp;
	public GameObject rightSkillTrigger;
	private RightSkill()
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
		if(Mathf.Abs(GetComponent<Image>().fillAmount-1)<0.05)
		{
			GetComponent<Image>().fillAmount = 0;
			rightSkillTrigger.SetActive(true);
		}
		
	}
	void Awake()
	{
		if(instance!=null&&instance!=this)
		{
			Destroy(gameObject);
		}
		else 
		{
			instance = this;
		}
		DontDestroyOnLoad (gameObject);
	}
	public static RightSkill getInstance()
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
