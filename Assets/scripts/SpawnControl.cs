using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnControl : MonoBehaviour {

    public GameObject[] gameObjects1 = new GameObject[4];
    public GameObject[] gameObjects2 = new GameObject[4];
    public GameObject mark04, mark05, mark06, mark07;
    //private GameObject spawn04, spawn05, spawn06, spawn07;
    // Use this for initialization
    void Start () { 
        int index = (int)Random.Range(0, 2);
        if(index == 0)
        {
            mark04.transform.position = gameObjects1[0].transform.position;
            mark05.transform.position = gameObjects1[1].transform.position;
            mark06.transform.position = gameObjects1[2].transform.position;
            mark07.transform.position = gameObjects1[3].transform.position;
        }
        else
        {
            mark04.transform.position = gameObjects2[0].transform.position;
            mark05.transform.position = gameObjects2[1].transform.position;
            mark06.transform.position = gameObjects2[2].transform.position;
            mark07.transform.position = gameObjects2[3].transform.position;
        }

        

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
