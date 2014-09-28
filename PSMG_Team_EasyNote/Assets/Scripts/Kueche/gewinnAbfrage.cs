using UnityEngine;
using System.Collections;

public class gewinnAbfrage : MonoBehaviour {

	// Use this for initialization
	// Use this for initialization
	public static int katzeStatus;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		OnMouseDown ();
	}

	void OnMouseDown (){
		gewinnAbfragen ();
	}

	void gewinnAbfragen (){
				if (abdruck_OnClicked.abdruck1Status == 1 && 
						abdruck_OnClicked.abdruck2Status == 1 && 
						abdruck_OnClicked.abdruck3Status == 1 && 
						abdruck_OnClicked.abdruck4Status == 1 && 
						abdruck_OnClicked.abdruck5Status == 1 && 
						abdruck_OnClicked.abdruck6Status == 1 && 
						abdruck_OnClicked.abdruck7Status == 1 && 
						abdruck_OnClicked.abdruck8Status == 1 && 
						abdruck_OnClicked.abdruck9Status == 1 && 
						abdruck_OnClicked.abdruck10Status == 1 && 
						abdruck_OnClicked.abdruck11Status == 1 && 
						abdruck_OnClicked.abdruck12Status == 1 && 
						abdruck_OnClicked.abdruck13Status == 1 && 
						abdruck_OnClicked.abdruck14Status == 1) {

						katzeStatus=1;	

				} else {
					nochNichtGewonnen();
				}
		}
	void nochNichtGewonnen(){
	


	}
}
