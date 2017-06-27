using UnityEngine;
using System.Collections;

public class Labyrinth : MonoBehaviour {
	public GameObject Wall;
	GameObject WallParent;
	public float WallLength = 0.8f;
	public int xSize = 5;
	public int ySize = 5;
	Vector2 initialPos;

	void CreateWall(){
		WallParent = new GameObject ();
		WallParent.name = "Walls";
		GameObject tempWall;
		initialPos = new Vector2 (0, 0);
		Vector2 myPos;

		for (int i = 0; i < ySize; i++) {
			for (int j = 0; j < xSize; j++) {
                myPos = new Vector2(initialPos.x + WallLength * j + WallLength / 2, initialPos.y + WallLength * i - WallLength / 2);
				tempWall = Instantiate (Wall, myPos, Quaternion.identity) as GameObject;
				tempWall.transform.parent = WallParent.transform;
			}
		}

		for (int i = 0; i < ySize; i++) {
			for (int j = 0; j < xSize; j++) {
				myPos = new Vector2 (initialPos.x + WallLength * j, initialPos.y + WallLength * i);
				//Instantiate (Wall, myPos, Quaternion.Euler(0,0,90),WallParent.transform);
			}
		}
	}

	void Start () {
		CreateWall ();	
	}

}
