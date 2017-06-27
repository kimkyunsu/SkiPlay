using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UserSystem4 : MonoBehaviour
{
    public float moveSpeed = 1;
    public Transform StartPoint;
    public Transform Cube;
    Transform[] Walls = new Transform[6];
    int X = 0;
    int Y = 0;
    int Z = 0;
    public float Ze = -2;
    public float Xmax = 6.4f; //가장자리 벽의 좌표
    public float Ymax = 6;
    int _i;

    void Start()
    {
        for (int i = 0; i < 6; i++) Walls[i] = Cube.transform.GetChild(i);
        transform.position = StartPoint.transform.position;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.tag)
        {
            case "goal":
                Debug.Log("Clear");
                Time.timeScale = 0;
                break;

            case "cubeup":
                if (Pad.State == 1)
                {
                    Pad.State = 0;
                    GetComponent<BoxCollider2D>().enabled = false;

                    /*if (Y == 0 && Z == 0)
                    {
                        X -= 90;
                    }
                    else if (X == 0 && Y == -90 && Z == 0)
                    {
                        Z += 90;
                    }
                    else if (X == 0 && Y == 90 && Z == 0)
                    {
                        Z -= 90;
                    }
                    else if (X == 0 && Y == 180 && Z == 0)
                    {
                        X += 90;
                    }
                    else if (X == -90 && Y == 0 && Z == 90)
                    {
                        X -= 90;
                    }
                    else if (X == -90 && Y == 0 && Z == -90)
                    {
                        X -= 90;
                    }
                    else if (X == 90 && Y == 0 && Z == -90)
                    {
                        X -= 90;
                    }
                    else if (X == 90 && Y == 0 && Z == 90)
                    {
                        X -= 90;
                    }
                    else if (X == 0 && Y == -90 && Z == 90)
                    {
                        Z += 90;
                    }
                    else if (X == 0 && Y == 90 && Z == -90)
                    {
                        Z -= 90;
                    }*/
                    if (X == 180 && Y == -90 && Z == 0) Z -= 90;
                    else if (X == 180 && Y == -90 && Z == 90) Z -= 90;
                    else if (Y == 0) X -= 90;
                    else if (Y == 180)
                    {
                        X += 90;
                    }
                    else if (Y == 90)
                    {
                        Z -= 90;
                    }
                    else if (Y == -90)
                    {
                        Z += 90;
                    }

                    if (X == -180)
                    {
                        X = 180;
                    }
                    else if (X == 270)
                    {
                        X = -90;
                    }
                    else if (Z == -180)
                    {
                        Z = 180;
                    }
                    else if (Z == 270)
                    {
                        Z = -90;
                    }

                    StartCoroutine(SetStage());
                    StartCoroutine(CubeUp());
                }
                break;
            case "cubedown":
                if (Pad.State == 1)
                {
                    Pad.State = 0;
                    GetComponent<BoxCollider2D>().enabled = false;
                    if (X == 180 && Y == 90 && Z == -90) Z -= 90;
                    else if (Y == 0) X += 90;
                    else if (Y == 180)
                    {
                        X -= 90;
                    }
                    else if (Y == 90)
                    {
                        Z += 90;
                    }
                    else if (Y == -90)
                    {
                        Z -= 90;
                    }

                    if (X == -180)
                    {
                        X = 180;
                    }
                    else if (X == 270)
                    {
                        X = -90;
                    }
                    else if (Z == -180)
                    {
                        Z = 180;
                    }
                    else if (Z == 270)
                    {
                        Z = -90;
                    }

                    StartCoroutine(SetStage());
                    StartCoroutine(CubeDown());
                }
                break;
            case "cubeleft":
                if (Pad.State == 1)
                {
                    Pad.State = 0;
                    GetComponent<BoxCollider2D>().enabled = false;
                    if (X == 180 && Y == 0 && Z == 90) Y -= 90;
                    else if (X == 180 && Z == 180) Y -= 90;
                    else if (X == 0)
                    {
                        Y -= 90;
                    }
                    else if (X == 180)
                    {
                        Y += 90;
                    }
                    else if (X == 90)
                    {
                        Z += 90;
                    }
                    else if (X == -90)
                    {
                        Z -= 90;
                    }
                    else if (Z == 90)
                    {
                        Z -= 90;
                    }
                    else if (Z == -90)
                    {
                        Z += 90;
                    }

                    if (Y == -180)
                    {
                        Y = 180;
                    }
                    else if (Y == 270)
                    {
                        Y = -90;
                    }
                    else if (Z == -180)
                    {
                        Z = 180;
                    }
                    else if (Z == 270)
                    {
                        Z = -90;
                    }

                    StartCoroutine(SetStage());
                    StartCoroutine(CubeLeft());
                }
                break;
            case "cuberight":
                if (Pad.State == 1)
                {
                    Pad.State = 0;
                    GetComponent<BoxCollider2D>().enabled = false;
                    if (X == 180 && Y == -90 && Z == 0) Y += 90;
                    else if (X == 180 && Y == -90 && Z == 90) Y += 90;
                    else if (X == 180 && Z == -90) Y += 90;
                    else if (X == 0) Y += 90;
                    else if (X == 180)
                    {
                        Y -= 90;
                    }
                    else if (X == 90)
                    {
                        Z -= 90;
                    }
                    else if (X == -90)
                    {
                        Z += 90;
                    }
                    else if (Z == 90)
                    {
                        Z += 90;
                    }
                    else if (Z == -90)
                    {
                        Z -= 90;
                    }

                    if (Y == -180)
                    {
                        Y = 180;
                    }
                    else if (Y == 270)
                    {
                        Y = -90;
                    }
                    else if (Z == -180)
                    {
                        Z = 180;
                    }
                    else if (Z == 270)
                    {
                        Z = -90;
                    }

                    StartCoroutine(SetStage());
                    StartCoroutine(CubeRight());                   
                }
                break;
        }
    }

    IEnumerator CubeUp()
    {
        while (_i <= 20)
        {
            Cube.Rotate(-4.276f, 0, 0, Space.World);
            transform.Translate(new Vector3(0, Ymax / -20, 0));
            _i++;
            yield return new WaitForFixedUpdate();
        }
        _i = 0;

        Cube.rotation = Quaternion.Euler(X, Y, Z);
        transform.position = new Vector3(transform.position.x, 0, Ze);
        GetComponent<BoxCollider2D>().enabled = true;
        Pad.State = 1;
    }
    IEnumerator CubeDown()
    {
        while (_i <= 20)
        {
            Cube.Rotate(4.276f, 0, 0, Space.World);
            transform.Translate(new Vector3(0, Ymax / 20, 0));
            _i++;
            yield return new WaitForFixedUpdate();
        }
        _i = 0;
        Cube.rotation = Quaternion.Euler(X, Y, Z);
        transform.position = new Vector3(transform.position.x, Ymax - 0.4f, Ze);
        GetComponent<BoxCollider2D>().enabled = true;
        Pad.State = 1;
    }
    IEnumerator CubeLeft()
    {
        while (_i <= 20)
        {
            Cube.Rotate(0, -4.276f, 0, Space.World);
            transform.Translate(new Vector3(Xmax / 20, 0, 0));
            _i++;
            yield return new WaitForFixedUpdate();
        }
        _i = 0;
        Cube.rotation = Quaternion.Euler(X, Y, Z);
        transform.position = new Vector3(Xmax - 0.4f, transform.position.y, Ze);
        GetComponent<BoxCollider2D>().enabled = true;
        Pad.State = 1;
    }
    IEnumerator CubeRight()
    {
        while (_i <= 20)
        {
            Cube.Rotate(0, 4.276f, 0, Space.World);
            transform.Translate(new Vector3(Xmax / -20, 0, 0));
            _i++;
            yield return new WaitForFixedUpdate();
        }
        _i = 0;
        Cube.rotation = Quaternion.Euler(X, Y, Z);
        transform.position = new Vector3(0.4f, transform.position.y, Ze);
        GetComponent<BoxCollider2D>().enabled = true;
        Pad.State = 1;
    }
    IEnumerator SetStage()
    {
        Debug.Log(X);
        Debug.Log(Y);
        Debug.Log(Z);
        for (int i = 0; i < 6; i++) Walls[i].gameObject.SetActive(false);       

        switch (X)
        {
            case 0:
                switch (Y)
                {
                    case 0:
                        switch (Z)
                        {
                            case 0:
                                Walls[0].gameObject.SetActive(true);
                                break;
                            case 90:
                                Walls[0].gameObject.SetActive(true);
                                break;
                            case 180:
                                Walls[0].gameObject.SetActive(true);
                                break;
                            case -90:
                                Walls[0].gameObject.SetActive(true);
                                break;
                        }
                        break;
                    case 90:
                        switch (Z)
                        {
                            case 0:
                                Walls[4].gameObject.SetActive(true);
                                break;
                            case 90:
                                Walls[1].gameObject.SetActive(true);
                                break;
                            case 180:
                                Walls[5].gameObject.SetActive(true);
                                break;
                            case -90:
                                Walls[3].gameObject.SetActive(true);
                                break;
                        }
                        break;
                    case 180:
                        switch (Z)
                        {
                            case 0:
                                Walls[2].gameObject.SetActive(true);
                                break;
                            case 90:
                                Walls[2].gameObject.SetActive(true);
                                break;
                            case 180:
                                Walls[2].gameObject.SetActive(true);
                                break;
                            case -90:
                                Walls[2].gameObject.SetActive(true);
                                break;
                        }
                        break;
                    case -90:
                        switch (Z)
                        {
                            case 0:
                                Walls[5].gameObject.SetActive(true);
                                break;
                            case 90:
                                Walls[3].gameObject.SetActive(true);
                                break;
                            case 180:
                                Walls[4].gameObject.SetActive(true);
                                break;
                            case -90:
                                Walls[1].gameObject.SetActive(true);
                                break;
                        }
                        break;
                }
                break;
            case 90:
                switch (Y)
                {
                    case 0:
                        switch (Z)
                        {
                            case 0:
                                Walls[1].gameObject.SetActive(true);
                                break;
                            case 90:
                                Walls[5].gameObject.SetActive(true);
                                break;
                            case 180:
                                Walls[3].gameObject.SetActive(true);
                                break;
                            case -90:
                                Walls[4].gameObject.SetActive(true);
                                break;
                        }
                        break;
                    case 90:
                        switch (Z)
                        {
                            case 0:
                                Walls[4].gameObject.SetActive(true);
                                break;
                            case 90:
                                Walls[1].gameObject.SetActive(true);
                                break;
                            case 180:
                                Walls[5].gameObject.SetActive(true);
                                break;
                            case -90:
                                Walls[3].gameObject.SetActive(true);
                                break;
                        }
                        break;
                    case 180:
                        switch (Z)
                        {
                            case 0:
                                Walls[3].gameObject.SetActive(true);
                                break;
                            case 90:
                                Walls[4].gameObject.SetActive(true);
                                break;
                            case 180:
                                Walls[1].gameObject.SetActive(true);
                                break;
                            case -90:
                                Walls[5].gameObject.SetActive(true);
                                break;
                        }
                        break;
                    case -90:
                        switch (Z)
                        {
                            case 0:
                                Walls[5].gameObject.SetActive(true);
                                break;
                            case 90:
                                Walls[3].gameObject.SetActive(true);
                                break;
                            case 180:
                                Walls[4].gameObject.SetActive(true);
                                break;
                            case -90:
                                Walls[1].gameObject.SetActive(true);
                                break;
                        }
                        break;
                }
                break;
            case 180:
                switch (Y)
                {
                    case 0:
                        switch (Z)
                        {
                            case 0:
                                Walls[2].gameObject.SetActive(true);
                                break;
                            case 90:
                                Walls[2].gameObject.SetActive(true);
                                break;
                            case 180:
                                Walls[2].gameObject.SetActive(true);
                                break;
                            case -90:
                                Walls[2].gameObject.SetActive(true);
                                break;
                        }
                        break;
                    case 90:
                        switch (Z)
                        {
                            case 0:
                                Walls[4].gameObject.SetActive(true);
                                break;
                            case 90:
                                Walls[1].gameObject.SetActive(true);
                                break;
                            case 180:
                                Walls[5].gameObject.SetActive(true);
                                break;
                            case -90:
                                Walls[3].gameObject.SetActive(true);
                                break;
                        }
                        break;
                    case 180:
                        switch (Z)
                        {
                            case 0:
                                Walls[0].gameObject.SetActive(true);
                                break;
                            case 90:
                                Walls[0].gameObject.SetActive(true);
                                break;
                            case 180:
                                Walls[0].gameObject.SetActive(true);
                                break;
                            case -90:
                                Walls[0].gameObject.SetActive(true);
                                break;
                        }
                        break;
                    case -90:
                        switch (Z)
                        {
                            case 0:
                                Walls[5].gameObject.SetActive(true);
                                break;
                            case 90:
                                Walls[3].gameObject.SetActive(true);
                                break;
                            case 180:
                                Walls[4].gameObject.SetActive(true);
                                break;
                            case -90:
                                Walls[1].gameObject.SetActive(true);
                                break;
                        }
                        break;
                }
                break;
            case -90:
                switch (Y)
                {
                    case 0:
                        switch (Z)
                        {
                            case 0:
                                Walls[3].gameObject.SetActive(true);
                                break;
                            case 90:
                                Walls[4].gameObject.SetActive(true);
                                break;
                            case 180:
                                Walls[1].gameObject.SetActive(true);
                                break;
                            case -90:
                                Walls[5].gameObject.SetActive(true);
                                break;
                        }
                        break;
                    case 90:
                        switch (Z)
                        {
                            case 0:
                                Walls[4].gameObject.SetActive(true);
                                break;
                            case 90:
                                Walls[1].gameObject.SetActive(true);
                                break;
                            case 180:
                                Walls[5].gameObject.SetActive(true);
                                break;
                            case -90:
                                Walls[3].gameObject.SetActive(true);
                                break;
                        }
                        break;
                    case 180:
                        switch (Z)
                        {
                            case 0:
                                Walls[1].gameObject.SetActive(true);
                                break;
                            case 90:
                                Walls[5].gameObject.SetActive(true);
                                break;
                            case 180:
                                Walls[3].gameObject.SetActive(true);
                                break;
                            case -90:
                                Walls[4].gameObject.SetActive(true);
                                break;
                        }
                        break;
                    case -90:
                        switch (Z)
                        {
                            case 0:
                                Walls[5].gameObject.SetActive(true);
                                break;
                            case 90:
                                Walls[3].gameObject.SetActive(true);
                                break;
                            case 180:
                                Walls[4].gameObject.SetActive(true);
                                break;
                            case -90:
                                Walls[1].gameObject.SetActive(true);
                                break;
                        }
                        break;
                }
                break;
        }
        yield return null;
    }
}