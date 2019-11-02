using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonScript : MonoBehaviour, IVirtualButtonEventHandler {

	public GameObject Hololens, Enviornment, videoPanel;

	// Use this for initialization
	void Start ()
	{
		VirtualButtonBehaviour [] vbs = GetComponentsInChildren<VirtualButtonBehaviour> ();
		for (int i = 0; i < vbs.Length; ++i)
		{
			vbs [i].RegisterEventHandler (this);
		}

		Hololens.SetActive (false);
		Enviornment.SetActive (false);
		videoPanel.SetActive (false);
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	public void OnButtonPressed (VirtualButtonBehaviour vb)
	{
		switch (vb.VirtualButtonName){
			case "Hololens":
				Hololens.SetActive (true);
				videoPanel.SetActive (true);
				Enviornment.SetActive (false);
				break;
			case "Effects":
				Hololens.SetActive (false);
				videoPanel.SetActive (false);
				Enviornment.SetActive (true);
				break;
		}
	}

	public void OnButtonReleased (VirtualButtonBehaviour vb)
	{
		Debug.Log ("VB Disabled");
	}
}
