using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour {
    string[] colors = { "red", "green", "magenta", "yellow", "cyan" };
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
                if(cube.tag == "red")
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
                if (cube.tag == "green")
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
                if (cube.tag == "red")
                {
                    cube.SetActive(false);
                }
                else
                {
                    cube.SetActive(true);
                }
            }
        }

        if (Input.GetKey(KeyCode.M))
        {
            foreach (GameObject cube in cubes)
            {
                if (cube.tag == "magenta")
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
                if (cube.tag == "yellow")
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
                if (cube.tag == "cyan")
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
