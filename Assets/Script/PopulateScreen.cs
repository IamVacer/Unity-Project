/*
 * The main component for populating the points of the array
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PopulateScreen : MonoBehaviour {

	int GRID_POINTS;
	float[,] dataY;
	public GameObject myObj;


    //The given loop to store the points onto the array dataY
	void PopulateArray() {
		for (int x = 0; x < GRID_POINTS; x++) {
			for (int z = 0; z < GRID_POINTS; z++) {
                dataY[x, z] = -((x - GRID_POINTS / 2) * (x - GRID_POINTS / 2) + (z - GRID_POINTS / 2) * (z - GRID_POINTS / 2)) / 500f + 10f;
			}
		}
    }

    //The method to transform "Cubeprefab" objects
    void PopulateObjects() {
		for (int x = 0; x < GRID_POINTS; x++) {
            for (int z = 0; z < GRID_POINTS; z++) {
                Vector3 objectPos = new Vector3(((float)x), dataY[x, z]* 10, ((float)z));
                GameObject myObject = Instantiate(myObj) as GameObject;
                myObject.transform.position = objectPos;
            }
        }
    }

    //To instantiate the data and points onto the screen
	void Start() {
		GRID_POINTS = 100;
		dataY = new float[GRID_POINTS,GRID_POINTS];
        PopulateArray();
        PopulateObjects();
    }

}
