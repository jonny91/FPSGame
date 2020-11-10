using System;
using System.Collections;
using System.Collections.Generic;
using Photon;
using UnityEngine;

public class NetworkTest : PunBehaviour
{
	private void Start()
	{
		PhotonNetwork.ConnectUsingSettings("0.0.1");
	}
}