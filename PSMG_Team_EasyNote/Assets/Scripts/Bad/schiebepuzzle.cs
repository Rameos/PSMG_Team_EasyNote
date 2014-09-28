using UnityEngine;
using System.Collections;

public class schiebepuzzle : MonoBehaviour {
	public AudioClip Fliesenschieben;
	public GameObject slot;
	float xtemp;
	float ytemp;
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		int positionTeil1x = GameObject.Find("Teil1").transform.position.x;
		int positionTeil1y = GameObject.Find("Teil1").transform.position.y;
		int positionTeil2x = GameObject.Find("Teil2").transform.position.x;
		int positionTeil2y = GameObject.Find("Teil2").transform.position.y;
		int positionTeil3x = GameObject.Find("Teil3").transform.position.x;
		int positionTeil3y = GameObject.Find("Teil3").transform.position.y;
		int positionTeil4x = GameObject.Find("Teil4").transform.position.x;
		int positionTeil4y = GameObject.Find("Teil4").transform.position.y;
		int positionTeil5x = GameObject.Find("Teil5").transform.position.x;
		int positionTeil5y = GameObject.Find("Teil5").transform.position.y;
		int positionTeil6x = GameObject.Find("Teil6").transform.position.x;
		int positionTeil6y = GameObject.Find("Teil6").transform.position.y;
		int positionTeil7x = GameObject.Find("Teil7").transform.position.x;
		int positionTeil7y = GameObject.Find("Teil7").transform.position.y;
		int positionTeil8x = GameObject.Find("Teil8").transform.position.x;
		int positionTeil8y = GameObject.Find("Teil8").transform.position.y;
		int positionTeil9x = GameObject.Find("Teil9").transform.position.x;
		int positionTeil9y = GameObject.Find("Teil9").transform.position.y;
		int positionTeil10x = GameObject.Find("Teil10").transform.position.x;
		int positionTeil10y = GameObject.Find("Teil10").transform.position.y;
		int positionTeil11x = GameObject.Find("Teil11").transform.position.x;
		int positionTeil11y = GameObject.Find("Teil11").transform.position.y;
		int positionTeil12x = GameObject.Find("Teil12").transform.position.x;
		int positionTeil12y = GameObject.Find("Teil12").transform.position.y;
		int positionTeil13x = GameObject.Find("Teil13").transform.position.x;
		int positionTeil13y = GameObject.Find("Teil13").transform.position.y;
		int positionTeil14x = GameObject.Find("Teil14").transform.position.x;
		int positionTeil14y = GameObject.Find("Teil14").transform.position.y;
		int positionTeil15x = GameObject.Find("Teil15").transform.position.x;
		int positionTeil15y = GameObject.Find("Teil15").transform.position.y;

		
	}
	
	void OnMouseUp(){
		//If theDistance==1 between tiles then swap tiles
		if(Vector3.Distance(transform.localPosition,slot.transform.position)==1){
			audio.PlayOneShot(Fliesenschieben);
			xtemp = transform.localPosition.x;
			ytemp = transform.localPosition.y;
			transform.localPosition = new Vector3(slot.transform.position.x, slot.transform.position.y, 0);
			slot.transform.position = new Vector3(xtemp, ytemp, 0);
			
		}	
		
	}
}﻿