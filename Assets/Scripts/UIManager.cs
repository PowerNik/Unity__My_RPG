﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

	public void NewGame()
	{
		SceneManager.LoadScene("Main");
	}

	public void Exit()
	{
		Application.Quit();
	}
}
