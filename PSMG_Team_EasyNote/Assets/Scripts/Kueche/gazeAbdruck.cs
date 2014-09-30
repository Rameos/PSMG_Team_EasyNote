using UnityEngine;
using System.Collections;
using iViewX;

public class gazeAbdruck : MonoBehaviourWithGazeComponent
{

    // Use this for initialization
    void Start () {
        gazeUI.Add(new GazeButton(new Rect(),
    "Rotate Cube"));
    }

    // Update is called once per frame
    void Update () {
        if (isDrawing)
        {
            foreach (GazeButton button in gazeUI)
            {
                button.Update();
            }
        }
    }

    private ArrayList gazeUI = new ArrayList();



        void OnGUI()
        {
            if (isDrawing)
            {
                foreach (GazeButton button in gazeUI)
                {
                    button.OnGUI();
                }
            }
        }

    public override void OnGazeStay(RaycastHit hit)
    {

/*        Color greenColour = new Color(0, 102, 0);

        renderer.material.color = greenColour;
*/        //if(Input.GetKeyDown(KeyCode.Space))
        //{
        //    //float r = Random.Range(0f,1f);
        //    //float g = Random.Range(0f,1f);
        //    //float b = Random.Range(0f,1f);
        //    Color greenColour = new Color(0, 102, 0);

        //    renderer.material.color = greenColour;
        //}

        if (gameObject.tag == "abdruck1"){
	        //float r = Random.Range(0f,1f);
	        //float g = Random.Range(0f,1f);
	        //float b = Random.Range(0f,1f);
	        Color greenColour = new Color(0, 102, 0);
	        
	        renderer.material.color = greenColour;
	        abdruck_OnClicked.abdruck1Status = 1; 
		}
		else if (gameObject.tag == "abdruck2"){
			//float r = Random.Range(0f,1f);
			//float g = Random.Range(0f,1f);
			//float b = Random.Range(0f,1f);
			Color greenColour = new Color(0, 102, 0);
			
			renderer.material.color = greenColour;
			abdruck_OnClicked.abdruck2Status = 1; 
		}
		else if (gameObject.tag == "abdruck3"){
			//float r = Random.Range(0f,1f);
			//float g = Random.Range(0f,1f);
			//float b = Random.Range(0f,1f);
			Color greenColour = new Color(0, 102, 0);
			
			renderer.material.color = greenColour;
			abdruck_OnClicked.abdruck3Status = 1; 
		}
		else if (gameObject.tag == "abdruck4"){
			//float r = Random.Range(0f,1f);
			//float g = Random.Range(0f,1f);
			//float b = Random.Range(0f,1f);
			Color greenColour = new Color(0, 102, 0);
			
			renderer.material.color = greenColour;
			abdruck_OnClicked.abdruck4Status = 1; 
		}
		else if (gameObject.tag == "abdruck5"){
			//float r = Random.Range(0f,1f);
			//float g = Random.Range(0f,1f);
			//float b = Random.Range(0f,1f);
			Color greenColour = new Color(0, 102, 0);
			
			renderer.material.color = greenColour;
			abdruck_OnClicked.abdruck5Status = 1; 
		}
		else if (gameObject.tag == "abdruck6"){
			//float r = Random.Range(0f,1f);
			//float g = Random.Range(0f,1f);
			//float b = Random.Range(0f,1f);
			Color greenColour = new Color(0, 102, 0);
			
			renderer.material.color = greenColour;
			abdruck_OnClicked.abdruck6Status = 1; 
		}
		else if (gameObject.tag == "abdruck7"){
			//float r = Random.Range(0f,1f);
			//float g = Random.Range(0f,1f);
			//float b = Random.Range(0f,1f);
			Color greenColour = new Color(0, 102, 0);
			
			renderer.material.color = greenColour;
			abdruck_OnClicked.abdruck7Status = 1; 
		}
		else if (gameObject.tag == "abdruck8"){
			//float r = Random.Range(0f,1f);
			//float g = Random.Range(0f,1f);
			//float b = Random.Range(0f,1f);
			Color greenColour = new Color(0, 102, 0);
			
			renderer.material.color = greenColour;
			abdruck_OnClicked.abdruck8Status = 1; 
		}
		else if (gameObject.tag == "abdruck9"){
			//float r = Random.Range(0f,1f);
			//float g = Random.Range(0f,1f);
			//float b = Random.Range(0f,1f);
			Color greenColour = new Color(0, 102, 0);
			
			renderer.material.color = greenColour;
			abdruck_OnClicked.abdruck9Status = 1; 
		}
		else if (gameObject.tag == "abdruck10"){
			//float r = Random.Range(0f,1f);
			//float g = Random.Range(0f,1f);
			//float b = Random.Range(0f,1f);
			Color greenColour = new Color(0, 102, 0);
			
			renderer.material.color = greenColour;
			abdruck_OnClicked.abdruck10Status = 1; 
		}
		else if (gameObject.tag == "abdruck11"){
			//float r = Random.Range(0f,1f);
			//float g = Random.Range(0f,1f);
			//float b = Random.Range(0f,1f);
			Color greenColour = new Color(0, 102, 0);
			
			renderer.material.color = greenColour;
			abdruck_OnClicked.abdruck11Status = 1; 
		}
		else if (gameObject.tag == "abdruck12"){
			//float r = Random.Range(0f,1f);
			//float g = Random.Range(0f,1f);
			//float b = Random.Range(0f,1f);
			Color greenColour = new Color(0, 102, 0);
			
			renderer.material.color = greenColour;
			abdruck_OnClicked.abdruck12Status = 1; 
		}
		else if (gameObject.tag == "abdruck13"){
			//float r = Random.Range(0f,1f);
			//float g = Random.Range(0f,1f);
			//float b = Random.Range(0f,1f);
			Color greenColour = new Color(0, 102, 0);
			
			renderer.material.color = greenColour;
			abdruck_OnClicked.abdruck13Status = 1; 
		}
		else if (gameObject.tag == "abdruck14"){
			//float r = Random.Range(0f,1f);
			//float g = Random.Range(0f,1f);
			//float b = Random.Range(0f,1f);
			Color greenColour = new Color(0, 102, 0);
			
			renderer.material.color = greenColour;
			abdruck_OnClicked.abdruck14Status = 1; 
		}
        
    }


    public bool isDrawing { get; set; }

    public override void OnGazeEnter(RaycastHit hit)
    {

    }

    public override void OnGazeExit()
    {
    
    }
}
