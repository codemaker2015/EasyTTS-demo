using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;

/// <summary>
/// This is a demo for selecting different kinds of text to speech engine that is installed on your phone.
/// </summary>
public class EasyTTSDemo_SelectEngine : MonoBehaviour
{
	[SerializeField]
	string stringToEdit = "In this demo you can know your different text to speech engine" +
		" that's been \ninstalled on your phone. You can hear the differences on how each \n" +
			"text to speech engine pronunciation and such.\nKindly choose either of SelectList or OpenTTSSettings" +
			" to find out.";
	[SerializeField]
	string engineName = "";
	[SerializeField]
	string enginePkg ="";
	[SerializeField]
	InputField inpText;
	[SerializeField]
	Dropdown dpdEngine;
	string[] nameArray, pkgArray;


	void Start(){

		pkgArray = EasyTTSUtil.GetEnginePkgArray();
		engineName = EasyTTSUtil.GetDefaultEngineName();
		enginePkg = pkgArray[0];
		EasyTTSUtil.Initialize(EasyTTSUtil.UnitedStates, enginePkg);
		nameArray = EasyTTSUtil.GetEngineNameArray();
		dpdEngine.AddOptions(new List<string>(nameArray));
		inpText.text = stringToEdit;
	}

	void OnApplicationQuit ()
	{
		EasyTTSUtil.Stop ();
	}

	public void OnEnterInput()
	{
		stringToEdit = inpText.text;
	}

	public void OpenTTSSetting()
    {
		EasyTTSUtil.OpenTTSSetting();
	}

	public void Speak()
	{
		EasyTTSUtil.SpeechAdd(stringToEdit);
	}

	public void Clear()
	{
		stringToEdit = "";
		inpText.text = "";
	}

	public void OnEngineChanged()
    {
		enginePkg = pkgArray[dpdEngine.value];
		engineName = dpdEngine.options[dpdEngine.value].text;
		EasyTTSUtil.Initialize(EasyTTSUtil.UnitedStates, enginePkg);
	}

}
