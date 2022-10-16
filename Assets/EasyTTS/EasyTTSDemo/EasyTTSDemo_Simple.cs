using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EasyTTSDemo_Simple : MonoBehaviour {

	[SerializeField]
	string stringToEdit = "Hello world";
	[SerializeField]
	InputField inpText;

	void Start(){
		EasyTTSUtil.Initialize (EasyTTSUtil.UnitedStates);
		stringToEdit = inpText.text;
	}
	
	void OnApplicationQuit() 
	{
		EasyTTSUtil.Stop ();
	}

	public void Speak()
    {
		EasyTTSUtil.SpeechAdd(stringToEdit);
	}

	public void Repeat()
	{
		EasyTTSUtil.SpeechFlush(stringToEdit);
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
}
