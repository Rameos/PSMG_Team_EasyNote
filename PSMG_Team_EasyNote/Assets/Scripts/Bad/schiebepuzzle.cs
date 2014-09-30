using UnityEngine;
using System.Collections;

public class schiebepuzzle : MonoBehaviour {
	public AudioClip Fliesenschieben;
	public GameObject slot;
	float xtemp;
	float ytemp;
	public float positionTeil1x;
	public	float positionTeil1y;
	public	float positionTeil2x;
	public	float positionTeil2y;
	public	float positionTeil3x;
	public	float positionTeil3y;
	public	float positionTeil4x;
	public	float positionTeil4y;
	public	float positionTeil5x;
	public	float positionTeil5y;
	public	float positionTeil6x;
	public	float positionTeil6y;
	public	float positionTeil7x;
	public	float positionTeil7y;
	public	float positionTeil8x;
	public	float positionTeil8y;
	public	float positionTeil9x;
	public	float positionTeil9y;
	public	float positionTeil10x;
	public	float positionTeil10y;
	public	float positionTeil11x;
	public	float positionTeil11y;
	public	float positionTeil12x;
	public	float positionTeil12y;
	public	float positionTeil13x;
	public	float positionTeil13y;
	public	float positionTeil14x;
	public	float positionTeil14y;
	public	float positionTeil15x;
	public	float positionTeil15y;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float positionTeil1x = GameObject.Find("Teil1").transform.position.x;
		float positionTeil1y = GameObject.Find("Teil1").transform.position.y;
		float positionTeil2x = GameObject.Find("Teil2").transform.position.x;
		float positionTeil2y = GameObject.Find("Teil2").transform.position.y;
		float positionTeil3x = GameObject.Find("Teil3").transform.position.x;
		float positionTeil3y = GameObject.Find("Teil3").transform.position.y;
		float positionTeil4x = GameObject.Find("Teil4").transform.position.x;
		float positionTeil4y = GameObject.Find("Teil4").transform.position.y;
		float positionTeil5x = GameObject.Find("Teil5").transform.position.x;
		float positionTeil5y = GameObject.Find("Teil5").transform.position.y;
		float positionTeil6x = GameObject.Find("Teil6").transform.position.x;
		float positionTeil6y = GameObject.Find("Teil6").transform.position.y;
		float positionTeil7x = GameObject.Find("Teil7").transform.position.x;
		float positionTeil7y = GameObject.Find("Teil7").transform.position.y;
		float positionTeil8x = GameObject.Find("Teil8").transform.position.x;
		float positionTeil8y = GameObject.Find("Teil8").transform.position.y;
		float positionTeil9x = GameObject.Find("Teil9").transform.position.x;
		float positionTeil9y = GameObject.Find("Teil9").transform.position.y;
		float positionTeil10x = GameObject.Find("Teil10").transform.position.x;
		float positionTeil10y = GameObject.Find("Teil10").transform.position.y;
		float positionTeil11x = GameObject.Find("Teil11").transform.position.x;
		float positionTeil11y = GameObject.Find("Teil11").transform.position.y;
		float positionTeil12x = GameObject.Find("Teil12").transform.position.x;
		float positionTeil12y = GameObject.Find("Teil12").transform.position.y;
		float positionTeil13x = GameObject.Find("Teil13").transform.position.x;
		float positionTeil13y = GameObject.Find("Teil13").transform.position.y;
		float positionTeil14x = GameObject.Find("Teil14").transform.position.x;
		float positionTeil14y = GameObject.Find("Teil14").transform.position.y;
		float positionTeil15x = GameObject.Find("Teil15").transform.position.x;
		float positionTeil15y = GameObject.Find("Teil15").transform.position.y;

		gewinnAbfrageBad ();
		
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

	void gewinnAbfrageBad(){
		if(positionTeil1x == 3 && positionTeil1y == -3 &&
		   positionTeil2x == 2 && positionTeil2y == -3 &&
		   positionTeil3x == 1 && positionTeil3y == -3 &&
		   positionTeil4x == 0 && positionTeil4y == -3 &&
		   positionTeil5x == 3 && positionTeil5y == -2 &&
		   positionTeil6x == 2 && positionTeil6y == -2 &&
		   positionTeil7x == 1 && positionTeil7y == -2 &&
		   positionTeil8x == 0 && positionTeil8y == -2 &&
		   positionTeil9x == 3 && positionTeil9y == -1 &&
		   positionTeil10x == 2 && positionTeil10y == -1 &&
		   positionTeil11x == 1 && positionTeil11y == -1 &&
		   positionTeil12x == 0 && positionTeil12y == -1 &&
		   positionTeil13x == 3 && positionTeil13y == 0 &&
		   positionTeil14x == 2 && positionTeil14y == 0 &&
		   positionTeil15x == 1 && positionTeil15y == 0 ){
			Application.LoadLevel(9);
		}
	}
}﻿