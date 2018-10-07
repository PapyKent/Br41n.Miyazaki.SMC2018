using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour {
    string[] colors = { "Red", "Green", "Blue", "Yellow", "Cyan" };
    List<GameObject> cubes = new List<GameObject>();

	// Use this for initialization
	void Start () {
        foreach(string c in colors)
        {
            foreach(GameObject cube in GameObject.FindGameObjectsWithTag(c))
            {
                cubes.Add(cube);
            }

        }
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.R))
        {
            foreach(GameObject cube in cubes)
            {
                if(cube.tag == "Red")
                {
                    cube.SetActive(false);
                } else
                {
                    cube.SetActive(true);
                }
            }
        }

        if (Input.GetKey(KeyCode.G))
        {
            foreach (GameObject cube in cubes)
            {
                if (cube.tag == "Green")
                {
                    cube.SetActive(false);
                }
                else
                {
                    cube.SetActive(true);
                }
            }
        }

        if (Input.GetKey(KeyCode.Y))
        {
            foreach (GameObject cube in cubes)
            {
                if (cube.tag == "Yellow")
                {
                    cube.SetActive(false);
                }
                else
                {
                    cube.SetActive(true);
                }
            }
        }

        if (Input.GetKey(KeyCode.B))
        {
            foreach (GameObject cube in cubes)
            {
                if (cube.tag == "Blue")
                {
                    cube.SetActive(false);
                }
                else
                {
                    cube.SetActive(true);
                }
            }
        }


        if (Input.GetKey(KeyCode.C))
        {
            foreach (GameObject cube in cubes)
            {
                if (cube.tag == "Cyan")
                {
                    cube.SetActive(false);
                }
                else
                {
                    cube.SetActive(true);
                }
            }
        }

    }
}
