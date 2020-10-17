using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class hitbox : MonoBehaviour
{
    public float rayLength;
    public LayerMask layerMask;
    Ray ray;
    RaycastHit hit;

    GUIStyle style = new GUIStyle();

    public GameObject X;
    public GameObject O;
    public GameObject slash1;
    public GameObject slash2;
    public GameObject slash3;

    private int[] pos = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

    private bool player1 = true;
    private bool win1 = false;
    private bool win2 = false;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (win1 != true && win2 != true)
        {
            Selection();
            WinCondition();
        }
        Reset();
    }

    void OnGUI()
    {
        style.fontSize = 100;

        if (win1 == true)
            GUI.Label(new Rect(Screen.width/2 - 300, Screen.height/2, 100, 200), "Player 1 WINS!", style);
        else if (win2 == true)
            GUI.Label(new Rect(Screen.width/2 - 300, Screen.height / 2, 100, 20), "Player 2 WINS!", style);
    }
    void Selection()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, rayLength, layerMask))
            {
                if (hit.collider.CompareTag("selection1") && pos[0] == 0)
                {
                    Debug.Log("This is a hitbox");
                    if (player1 == true)
                    {
                        //GameObject xPiece = (GameObject)Instantiate(X, new Vector3(-8, 7, 8), transform.rotation);
                        PlaceXPiece(-8, 7, 8);
                        pos[0] = 1;
                        player1 = false;
                    }
                    else
                    {
                        //GameObject xPiece = (GameObject)Instantiate(O, new Vector3(-8, 7, 8), transform.rotation);
                        PlaceOPiece(-8, 7, 7.5f);
                        pos[0] = 2;
                        player1 = true;
                    }
                }

                else if (hit.collider.CompareTag("selection2") && pos[1] == 0)
                {
                    Debug.Log("This is a hitbox");
                    if (player1 == true)
                    {
                        //GameObject xPiece = (GameObject)Instantiate(X, new Vector3(-8, 7, 8), transform.rotation);
                        PlaceXPiece(0, 7, 8);
                        pos[1] = 1;
                        player1 = false;
                    }
                    else
                    {
                        //GameObject xPiece = (GameObject)Instantiate(O, new Vector3(-8, 7, 8), transform.rotation);
                        PlaceOPiece(0, 7, 7.5f);
                        pos[1] = 2;
                        player1 = true;
                    }
                }

                else if (hit.collider.CompareTag("selection3") && pos[2] == 0)
                {
                    Debug.Log("This is a hitbox");
                    if (player1 == true)
                    {
                        //GameObject xPiece = (GameObject)Instantiate(X, new Vector3(-8, 7, 8), transform.rotation);
                        PlaceXPiece(8, 7, 8);
                        pos[2] = 1;
                        player1 = false;
                    }
                    else
                    {
                        //GameObject xPiece = (GameObject)Instantiate(O, new Vector3(-8, 7, 8), transform.rotation);
                        PlaceOPiece(8, 7, 7.5f);
                        pos[2] = 2;
                        player1 = true;
                    }
                }

                else if (hit.collider.CompareTag("selection4") && pos[3] == 0)
                {
                    Debug.Log("This is a hitbox");
                    if (player1 == true)
                    {
                        //GameObject xPiece = (GameObject)Instantiate(X, new Vector3(-8, 7, 8), transform.rotation);
                        PlaceXPiece(-8, 1, 8);
                        pos[3] = 1;
                        player1 = false;
                    }
                    else
                    {
                        PlaceOPiece(-8, 1, 7.5f);
                        pos[3] = 2;
                        player1 = true;
                    }
                }

                else if (hit.collider.CompareTag("selection5") && pos[4] == 0)
                {
                    Debug.Log("This is a hitbox");
                    if (player1 == true)
                    {
                        PlaceXPiece(0, 1, 8);
                        pos[4] = 1;
                        player1 = false;
                    }
                    else
                    {
                        PlaceOPiece(0, 1, 7.5f);
                        pos[4] = 2;
                        player1 = true;
                    }
                }

                else if (hit.collider.CompareTag("selection6") && pos[5] == 0)
                {
                    Debug.Log("This is a hitbox");
                    if (player1 == true)
                    {
                        PlaceXPiece(8, 1, 8);
                        pos[5] = 1;
                        player1 = false;
                    }
                    else
                    {
                        PlaceOPiece(8, 1, 7.5f);
                        pos[5] = 2;
                        player1 = true;
                    }
                }

                else if (hit.collider.CompareTag("selection7") && pos[6] == 0)
                {
                    Debug.Log("This is a hitbox");
                    if (player1 == true)
                    {
                        PlaceXPiece(-8, -5, 8);
                        pos[6] = 1;
                        player1 = false;
                    }
                    else
                    {
                        PlaceOPiece(-8, -5, 7.5f);
                        pos[6] = 2;
                        player1 = true;
                    }
                }

                else if (hit.collider.CompareTag("selection8") && pos[7] == 0)
                {
                    Debug.Log("This is a hitbox");
                    if (player1 == true)
                    {
                        PlaceXPiece(0, -5, 8);
                        pos[7] = 1;
                        player1 = false;
                    }
                    else
                    {
                        PlaceOPiece(0, -5, 7.5f);
                        pos[7] = 2;
                        player1 = true;
                    }
                }

                else if (hit.collider.CompareTag("selection9") && pos[8] == 0)
                {
                    Debug.Log("This is a hitbox");
                    if (player1 == true)
                    {
                        PlaceXPiece(8, -5, 8);
                        pos[8] = 1;
                        player1 = false;
                    }
                    else
                    {
                        PlaceOPiece(8, -5, 7.5f);
                        pos[8] = 2;
                        player1 = true;
                    }
                }

                else
                {
                    Debug.Log("This isn't a Player");
                }
            }
        }
    }

    void WinCondition()
    {
        if ((pos[0] == 1 && pos[1] == 1 && pos[2] == 1) || (pos[0] == 2 && pos[1] == 2 && pos[2] == 2))
        {
            GameObject _slash = (GameObject)Instantiate(slash1, new Vector3(0, 7, 8), Quaternion.Euler(new Vector3(0, 90, 90)));
        }

        else if ((pos[3] == 1 && pos[4] == 1 && pos[5] == 1) || (pos[3] == 2 && pos[4] == 2 && pos[5] == 2))
        {
            GameObject _slash = (GameObject)Instantiate(slash1, new Vector3(0, 1, 8), Quaternion.Euler(new Vector3(0, 90, 90)));
        }

        else if ((pos[6] == 1 && pos[7] == 1 && pos[8] == 1) || (pos[6] == 2 && pos[7] == 2 && pos[8] == 2))
        {
            GameObject _slash = (GameObject)Instantiate(slash1, new Vector3(0, -5, 8), Quaternion.Euler(new Vector3(0, 90, 90)));
        }

        else if((pos[0] == 1 && pos[3] == 1 && pos[6] == 1) || (pos[0] == 2 && pos[3] == 2 && pos[6] == 2))
        {
            GameObject _slash = (GameObject)Instantiate(slash2, new Vector3(-8, 1, 8), Quaternion.Euler(new Vector3(90, 0, 0)));
        }

        else if ((pos[1] == 1 && pos[4] == 1 && pos[7] == 1) || (pos[1] == 2 && pos[4] == 2 && pos[7] == 2))
        {
            GameObject _slash = (GameObject)Instantiate(slash2, new Vector3(0, 1, 8), Quaternion.Euler(new Vector3(90, 0, 0)));
        }

        else if ((pos[2] == 1 && pos[5] == 1 && pos[8] == 1) || (pos[2] == 2 && pos[5] == 2 && pos[8] == 2))
        {
            GameObject _slash = (GameObject)Instantiate(slash2, new Vector3(8, 1, 8), Quaternion.Euler(new Vector3(90, 0, 0)));
        }

        else if ((pos[0] == 1 && pos[4] == 1 && pos[8] == 1) || (pos[0] == 2 && pos[4] == 2 && pos[8] == 2))
        {
            GameObject _slash = (GameObject)Instantiate(slash3, new Vector3(0, 1, 8), Quaternion.Euler(new Vector3(37, 90, 90)));
        }

        else if ((pos[2] == 1 && pos[4] == 1 && pos[6] == 1) || (pos[2] == 2 && pos[4] == 2 && pos[6] == 2))
        {
            GameObject _slash = (GameObject)Instantiate(slash3, new Vector3(0, 1, 8), Quaternion.Euler(new Vector3(-37, 90, 90)));
        }

        for (int i = 1; i <= 2; i++)
        if((pos[0] == i && pos[1] == i && pos[2] == i) || (pos[3] == i && pos[4] == i && pos[5] == i) || (pos[6] == i && pos[7] == i && pos[8] == i) ||
           (pos[0] == i && pos[3] == i && pos[6] == i) || (pos[1] == i && pos[4] == i && pos[7] == i) || (pos[2] == i && pos[5] == i && pos[8] == i) ||
           (pos[0] == i && pos[4] == i && pos[8] == i) || (pos[2] == i && pos[4] == i && pos[6] == i))
        {
                if (i == 1)
                {
                    win1 = true;
                    Debug.Log("Player 1 Wins");
                }
                else if (i == 2)
                {
                    win2 = true;
                    Debug.Log("Player 2 Wins");
                }
            }
    }

    void Reset()
    {
        if (Input.GetKeyDown(KeyCode.R))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void PlaceXPiece(float x, float y, float z)
    {
        GameObject xPiece = (GameObject)Instantiate(X, new Vector3(x, y, z), transform.rotation);
    }

    void PlaceOPiece(float x, float y, float z)
    {
        GameObject xPiece = (GameObject)Instantiate(O, new Vector3(x, y, z), transform.rotation);
    }

    
}
