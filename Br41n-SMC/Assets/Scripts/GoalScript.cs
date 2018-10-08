using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalScript : MonoBehaviour {
    public Text goalText;
    public Image goalImage;
    public GameObject Textgo;
    public GameObject ImageGo;
    //public Canvas canvas;

	// Use this for initialization
	void Start () {
        ImageGo.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.name == "player")
        {
            Debug.Log("Enter");
            Textgo.SetActive(true);
            //goalText.text = "WIN!!";
            ImageGo.SetActive(true);
        }
        
    }
}
