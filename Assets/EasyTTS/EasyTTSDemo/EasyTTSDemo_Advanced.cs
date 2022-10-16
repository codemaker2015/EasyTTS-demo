using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/// <summary>
/// This is a demo for selecting different kinds of text to speech engine that is installed on your phone.
/// </summary>
public class EasyTTSDemo_Advanced: MonoBehaviour {

	[SerializeField]
	string stringToEdit = "Hello world";
	[SerializeField]
	float volume = 1f;
	[SerializeField]
	float pitch = 1f;
	[SerializeField]
	float rate = 0.5f;
	[SerializeField]
	InputField inpText;
	[SerializeField]
	Slider slrVolume;
	[SerializeField]
	Slider slrPitch;
	[SerializeField]
	Slider slrRate;
	[SerializeField]
	Text txtVolume;
	[SerializeField]
	Text txtPitch;
	[SerializeField]
	Text txtRate;



	void Start(){
		stringToEdit = inpText.text;
	}

	void OnApplicationQuit() 
	{
		EasyTTSUtil.Stop ();
	}

	public void Speak()
	{
		EasyTTSUtil.SpeechAdd(stringToEdit, volume, rate, pitch);
	}

	public void Repeat()
	{
		EasyTTSUtil.SpeechFlush(stringToEdit, volume, rate, pitch);
	}

	public void Stop()
	{
		EasyTTSUtil.StopSpeech();
	}

	public void Clear()
	{
		stringToEdit = "";
		inpText.text = "";
	}

	public void OnEnterInput()
	{
		stringToEdit = inpText.text;
	}

	public void onVolumeChanged()
	{
		volume = slrVolume.value;
		txtVolume.text = (volume * 100 ) +"%";
	}
	
	public void onPitchChanged()
	{
		pitch = slrPitch.value;
		txtPitch.text = (pitch * 100) + "%";
	}
	
	public void onRateChanged()
	{
		rate = slrRate.value;
		txtRate.text = (rate * 100) + "%";
	}
}
