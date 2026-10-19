using System;
using BepInEx;
using HarmonyLib;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MuteGTVButton
{
	[BepInPlugin("default.MuteGTVButton", "MuteGTVButton", "1.0.0")]
	public class Plugin : BaseUnityPlugin
	{
		private bool _a;
        void Start()
		{
			SceneManager.sceneLoaded += OnSceneLoaded;
		}

        void OnSceneLoaded(Scene scene, LoadSceneMode mode)
        {
	        if (scene.name == "City")
	        {
		        foreach (GameObject obj in Resources.FindObjectsOfTypeAll<GameObject>()) if (obj.name == "MuteGTVButton") obj.SetActive(true);
		        SceneManager.sceneLoaded -= OnSceneLoaded;
	        }
        }
	}
}
