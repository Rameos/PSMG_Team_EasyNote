using UnityEngine;
using System.Collections;

public class abdruck_OnClicked : MonoBehaviour {

	public static int abdruck1Status;
	public static int abdruck2Status;
	public static int abdruck3Status;
	public static int abdruck4Status;
	public static int abdruck5Status;
	public static int abdruck6Status;
	public static int abdruck7Status;
	public static int abdruck8Status;
	public static int abdruck9Status;
	public static int abdruck10Status;
	public static int abdruck11Status;
	public static int abdruck12Status;
	public static int abdruck13Status;
	public static int abdruck14Status;

    //public int[] abdruckStatus = new int[12];
    //public bool katzeStatus = false;
    //private int currentAbdruck;

    //// Use this for initialization
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    //OnMouseDown();
    //}

    //public void abdruck(int currentAbdruck)
    //{
    //    GameObject[] abdruck = GameObject.FindGameObjectsWithTag("abdruck");
    //    if (currentAbdruck == 0)
    //    {
    //        OnMouseDown();
    //    }
    //}

    void OnMouseDown(){
		if (gameObject.tag == "abdruck1"){
	        //float r = Random.Range(0f,1f);
	        //float g = Random.Range(0f,1f);
	        //float b = Random.Range(0f,1f);
	        Color greenColour = new Color(0, 102, 0);
	        
	        renderer.material.color = greenColour;
	        abdruck1Status = 1; 
		}
		else if (gameObject.tag == "abdruck2"){
			//float r = Random.Range(0f,1f);
			//float g = Random.Range(0f,1f);
			//float b = Random.Range(0f,1f);
			Color greenColour = new Color(0, 102, 0);
			
			renderer.material.color = greenColour;
			abdruck2Status = 1; 
		}
		else if (gameObject.tag == "abdruck3"){
			//float r = Random.Range(0f,1f);
			//float g = Random.Range(0f,1f);
			//float b = Random.Range(0f,1f);
			Color greenColour = new Color(0, 102, 0);
			
			renderer.material.color = greenColour;
			abdruck3Status = 1; 
		}
		else if (gameObject.tag == "abdruck4"){
			//float r = Random.Range(0f,1f);
			//float g = Random.Range(0f,1f);
			//float b = Random.Range(0f,1f);
			Color greenColour = new Color(0, 102, 0);
			
			renderer.material.color = greenColour;
			abdruck4Status = 1; 
		}
		else if (gameObject.tag == "abdruck5"){
			//float r = Random.Range(0f,1f);
			//float g = Random.Range(0f,1f);
			//float b = Random.Range(0f,1f);
			Color greenColour = new Color(0, 102, 0);
			
			renderer.material.color = greenColour;
			abdruck5Status = 1; 
		}
		else if (gameObject.tag == "abdruck6"){
			//float r = Random.Range(0f,1f);
			//float g = Random.Range(0f,1f);
			//float b = Random.Range(0f,1f);
			Color greenColour = new Color(0, 102, 0);
			
			renderer.material.color = greenColour;
			abdruck6Status = 1; 
		}
		else if (gameObject.tag == "abdruck7"){
			//float r = Random.Range(0f,1f);
			//float g = Random.Range(0f,1f);
			//float b = Random.Range(0f,1f);
			Color greenColour = new Color(0, 102, 0);
			
			renderer.material.color = greenColour;
			abdruck7Status = 1; 
		}
		else if (gameObject.tag == "abdruck8"){
			//float r = Random.Range(0f,1f);
			//float g = Random.Range(0f,1f);
			//float b = Random.Range(0f,1f);
			Color greenColour = new Color(0, 102, 0);
			
			renderer.material.color = greenColour;
			abdruck8Status = 1; 
		}
		else if (gameObject.tag == "abdruck9"){
			//float r = Random.Range(0f,1f);
			//float g = Random.Range(0f,1f);
			//float b = Random.Range(0f,1f);
			Color greenColour = new Color(0, 102, 0);
			
			renderer.material.color = greenColour;
			abdruck9Status = 1; 
		}
		else if (gameObject.tag == "abdruck10"){
			//float r = Random.Range(0f,1f);
			//float g = Random.Range(0f,1f);
			//float b = Random.Range(0f,1f);
			Color greenColour = new Color(0, 102, 0);
			
			renderer.material.color = greenColour;
			abdruck10Status = 1; 
		}
		else if (gameObject.tag == "abdruck11"){
			//float r = Random.Range(0f,1f);
			//float g = Random.Range(0f,1f);
			//float b = Random.Range(0f,1f);
			Color greenColour = new Color(0, 102, 0);
			
			renderer.material.color = greenColour;
			abdruck11Status = 1; 
		}
		else if (gameObject.tag == "abdruck12"){
			//float r = Random.Range(0f,1f);
			//float g = Random.Range(0f,1f);
			//float b = Random.Range(0f,1f);
			Color greenColour = new Color(0, 102, 0);
			
			renderer.material.color = greenColour;
			abdruck12Status = 1; 
		}
		else if (gameObject.tag == "abdruck13"){
			//float r = Random.Range(0f,1f);
			//float g = Random.Range(0f,1f);
			//float b = Random.Range(0f,1f);
			Color greenColour = new Color(0, 102, 0);
			
			renderer.material.color = greenColour;
			abdruck13Status = 1; 
		}
		else if (gameObject.tag == "abdruck14"){
			//float r = Random.Range(0f,1f);
			//float g = Random.Range(0f,1f);
			//float b = Random.Range(0f,1f);
			Color greenColour = new Color(0, 102, 0);
			
			renderer.material.color = greenColour;
			abdruck14Status = 1; 
		}
    }

}
