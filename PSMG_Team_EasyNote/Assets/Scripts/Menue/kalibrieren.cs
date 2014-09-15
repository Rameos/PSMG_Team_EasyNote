using UnityEngine;
using System.Threading;
using System.Collections;
using iViewX;


	public class kalibrieren : MonoBehaviour {

		// Use this for initialization
		void Start () {
		
		}
		
		// Update is called once per frame
		void Update () {
		
		}
	    void OnClicked()
	    {
			GazeControlComponent.Instance.StartCalibration();
		}


	}
