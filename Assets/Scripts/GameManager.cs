using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {
	public Text IP,controllertext;
	// Use this for initialization
	void Start () {
		IP.text = Network.player.ipAddress;
	}

	public void StartGame()
	{
		SceneManager.LoadScene("MainGame");
	}
	void Update()
	{
		if (NetworkServer.connections.Count > 0)
		{
			controllertext.text = "true";
		}
		else
		{
			controllertext.text = "false";
		}
		
	}
}
