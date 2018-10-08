using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject colorA;
    public GameObject colorB;
    public GameObject colorC;
    public GameObject colorD;
    public GameObject colorE;
    public string previousColor;

    List<GameObject> listColors;

    // Use this for initialization
    void Start () {
        listColors.Add(colorA);
        listColors.Add(colorB);
        listColors.Add(colorC);
        listColors.Add(colorD);
        listColors.Add(colorE);

        colorD.SetActive(false);


        previousColor = "GREEN";
    }
	
	// Update is called once per frame
	void FixedUpdate () {
		
        if(TestScript.result != previousColor)
        {
            foreach (GameObject go in listColors)
            {
                go.SetActive(true);
                if(go.GetComponent<GroupColor>().ColorId == TestScript.result)
                {
                    go.SetActive(false);
                    previousColor = go.GetComponent<GroupColor>().ColorId;
                }
            }
        }
	}
}
