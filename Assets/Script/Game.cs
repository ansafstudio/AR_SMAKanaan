using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimplePopup;

public class Game : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            SimplePopupManager.Instance.CreatePopup("Are you sure to quit?");
            SimplePopupManager.Instance.AddButton("Yes", delegate { Application.Quit(); });
            SimplePopupManager.Instance.AddButton("No", delegate { SimplePopupManager.Instance.HidePopup(); });
            SimplePopupManager.Instance.ShowPopup();
        }
		
	}
}
