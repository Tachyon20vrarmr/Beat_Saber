﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Networking.NetworkSystem;

public class NetworkServerUI : MonoBehaviour {
	private float speed = 20f;
	void OnGUI()
	{
		/*string ipaddress = Network.player.ipAddress;
		GUI.Box(new Rect(10,Screen.height - 50 , 100, 50), ipaddress);
		GUI.Label(new Rect(20, Screen.height - 35, 100, 20), "Status : " + NetworkServer.active);
		GUI.Label(new Rect(20, Screen.height - 20, 100, 20), "Connected : " + NetworkServer.connections.Count);*/
	}
	void Start () {
		NetworkServer.Listen(25000);
		NetworkServer.RegisterHandler(888, ServerRecieveMessage);
	}
	void ServerRecieveMessage(NetworkMessage message)
	{
		StringMessage msg = new StringMessage();
		msg.value = message.ReadMessage<StringMessage>().value;
		string[] val = msg.value.Split('|');
		Calibrator.transform.eulerAngles = new Vector3((float.Parse(val[2])), float.Parse(val[1]), float.Parse(val[0])*0);
		Calibrator.transform.position = Vector3.Lerp(Calibrator.transform.position, new Vector3((float.Parse(val[3])), float.Parse(val[4]), float.Parse(val[5])), 0.5f);
	}
}
