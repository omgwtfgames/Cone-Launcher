﻿using UnityEngine;
using System.Collections;

public class SettingsPanel : MonoBehaviour {

	protected float timer;

	public virtual string Title
	{
		get {
			return "Test";
		}
	}

	public virtual void Do () {
		if (timer > 0) {
			timer -= Time.deltaTime;
		} else {
			timer = 0;
		}
	}

	// Update is called once per frame
	public virtual void Draw () {
		Settings.guiSkin.box.normal.textColor = new Color (1, 1, 1, 0.75f);	
		Settings.guiSkin.box.fontSize = Mathf.RoundToInt(Screen.width*0.045f);
		
		GUI.Box (new Rect (Screen.width * 0.4f, Screen.height * 0.15f, Screen.width * 0.035f * Title.Length, Screen.width * 0.05f),
				Title.ToUpper());
	}
}
