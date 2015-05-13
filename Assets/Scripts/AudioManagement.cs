using UnityEngine;
using System.Collections;

public class AudioManagement : MonoBehaviour {
	public AudioClip pong;
	private static AudioManagement instance;
	private AudioSource audioSource;
	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
	
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
			audioSource = (AudioSource)GetComponent<AudioSource>();
		}
	}
	public static AudioManagement getInstance()
	{
		return instance;
	}
	public void PlayPong()
	{
		audio.PlayOneShot(pong);
	}
	public AudioSource getAudioSource()
	{
		return audioSource;
	}
}
