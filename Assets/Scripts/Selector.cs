﻿using UnityEngine;
using System.Collections;

public class Selector : MonoBehaviour 
{
	public GameObject draw;
	public GameObject bin;
	public GameObject jeep;
	public GameObject table;
	public GameObject sink;
	public GameObject tablep;
	public GameObject sinkp;
	public GameObject drawp;
	public GameObject binp;
	public GameObject jeepp;

	// Use this for initialization
	void Start () 
	{
		draw.SetActive (false);
		bin.SetActive (false);
		jeep.SetActive (false);
		table.SetActive (false);
		sink.SetActive (false);
		tablep.SetActive(false);
		sinkp.SetActive (false);
		drawp.SetActive (false);
		binp.SetActive (false);
		jeepp.SetActive (false);
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public void draww()
	{
		draw.SetActive (true);
		bin.SetActive (false);
		jeep.SetActive (false);
		table.SetActive (false);
		sink.SetActive (false);
		drawp.SetActive (true);
		binp.SetActive (false);
		jeepp.SetActive (false);
	}

	public void binn()
	{
		bin.SetActive (true);
		draw.SetActive (false);
		jeep.SetActive (false);
		table.SetActive (false);
		sink.SetActive (false);
		binp.SetActive (true);
		jeepp.SetActive (false);

	}

	public void jeeep()
	{
		jeep.SetActive (true);
		draw.SetActive (false);
		bin.SetActive (false);
		table.SetActive (false);
		sink.SetActive (false);
		binp.SetActive (false);
		jeepp.SetActive (true);

	}

	public void tabble()
	{
		table.SetActive (true);
		draw.SetActive (false);
		bin.SetActive (false);
		jeep.SetActive (false);
		sink.SetActive (false);
		tablep.SetActive (true);
		binp.SetActive (false);
		jeepp.SetActive (false);
	}

	public void sinkk()
	{
		sink.SetActive (true);
		draw.SetActive (false);
		bin.SetActive (false);
		jeep.SetActive (false);
		table.SetActive (false);
		sinkp.SetActive (true);
		binp.SetActive (false);
		jeepp.SetActive (false);
	}
}