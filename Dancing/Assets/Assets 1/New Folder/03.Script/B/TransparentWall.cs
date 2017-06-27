using UnityEngine;
using System.Collections;

public class TransparentWall : MonoBehaviour {
    SpriteRenderer[] Walls;
    public int size;

    void Start () {
        size = transform.childCount;
        Walls = new SpriteRenderer[size];
        for (int i = 0; i < size; i++)
        {
            Walls[i] = transform.GetChild(i).GetComponent<SpriteRenderer>();
        }
        StartCoroutine(ChangeWalls());
    }

	IEnumerator ChangeWalls()
    {
        while (size > 0)
        {
            yield return new WaitForSeconds(3);
            for (int i = 0; i < size; i++)
            {
                Walls[i].color = new Color(1, 1, 1, 5 / 6f);
            }
            yield return new WaitForSeconds(3);
            for (int i = 0; i < size; i++)
            {
                Walls[i].color = new Color(1, 1, 1, 2 / 3f);
            }
            yield return new WaitForSeconds(3);
            for (int i = 0; i < size; i++)
            {
                Walls[i].color = new Color(1, 1, 1, 1 / 2f);
            }
            yield return new WaitForSeconds(3);
            for (int i = 0; i < size; i++)
            {
                Walls[i].color = new Color(1, 1, 1, 1 / 3f);
            }
            yield return new WaitForSeconds(3);
            for (int i = 0; i < size; i++)
            {
                Walls[i].color = new Color(1, 1, 1, 0);
            }

            yield return new WaitForSeconds(5);
            for (int i = 0; i < size; i++)
            {
                Walls[i].color = new Color(1, 1, 1, 1);
            }
        }

    }
}
