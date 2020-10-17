using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class placePiece : MonoBehaviour
{
    public GameObject X;
    public GameObject O;

    private int[] pos = {0};
    public int _pos;

    private struct Coordinates
    {
        private int x; 
        private int y;
        private int z;

        public Coordinates(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }

    private bool hasPlaced = false;


    Coordinates topLeft = new Coordinates(-8, 7, 8);
    Coordinates top = new Coordinates(0, 7, 8);
    Coordinates topRight = new Coordinates(8, 7, 8);
    Coordinates middleLeft = new Coordinates(-8, 1, 8);
    Coordinates middle = new Coordinates(0, 1, 8);
    Coordinates middleRight = new Coordinates(8, 1, 8);
    Coordinates bottomLeft = new Coordinates(-8, -5, 8);
    Coordinates bottom = new Coordinates(0, -5, 8);
    Coordinates bottomRight = new Coordinates(8, -5, 8);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && hasPlaced == false)
        {

            /*switch (_pos)
            {
                case 0:
                    GameObject xPiece = (GameObject)Instantiate(X, new Vector3(-8, 7, 8), transform.rotation);
                    hasPlaced = true;
                    break;
                default:
                    Debug.Log("Nothing here");
                    break;
            }*/
        }
    }
}
