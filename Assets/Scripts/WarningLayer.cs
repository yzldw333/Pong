using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class WarningLayer : MonoBehaviour {

	float lifeTime = 0;
	int progress = 1;
	Image image;
	// Use this for initialization


	// Update is called once per frame
	void Update () {
		//SlowDownTrigger's Blink Effect Animation
		if(progress==1&&image.color.a<0.2)
		{
			image.color = new Color(image.color.r,image.color.g,image.color.b,image.color.a+0.008f);
			if(image.color.a>=0.25) progress=2;
		}
		else if(progress==2&&image.color.a>0)
		{
			image.color = new Color(image.color.r,image.color.g,image.color.b,image.color.a-0.008f);
			if(image.color.a<=0.01) progress=1;
		}
		lifeTime += Time.deltaTime;
		if(lifeTime>5)
		{
			GameObject ball = GameObject.Find("Ball");
			lifeTime = 0;
			ball.rigidbody2D.velocity = ball.rigidbody2D.velocity.normalized * DataBean.getInstance()._velocity;
			DataBean.getInstance().ifSlowed = false;
			DataBean.getInstance().slowScale = 1;
			gameObject.SetActive(false);

		}
	}
	void Awake()
	{
		image = (Image)GetComponent<Image> ();
		progress = 1;
		lifeTime = 0;
		image.color = new Color (image.color.r, image.color.g, image.color.b, 0);
	}
}
