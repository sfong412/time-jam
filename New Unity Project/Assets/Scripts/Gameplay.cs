using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameplay : MonoBehaviour
{
    public float scrollSpeed = 1f;
    public float slowDownFactor = 1;

    public bool slowDownThereBuster = false;
    public bool slowDownInitiate = false;
    public Transform movingThing;

    Transform placedBlocks;
    Camera mainCamera;

    Vector3 worldPosition;

    Grid grid;

    public GameObject block1;
    public GameObject block2;
    public GameObject block3;
    public GameObject block4;
    public GameObject block5;
    // Start is called before the first frame update
    void Start()
    {
        grid = GameObject.Find("Hazard Generator").GetComponent<Grid>();

        mainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();

        placedBlocks = GameObject.Find("Placed Blocks").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }

      //Slows down time
         if (Input.GetMouseButton(0))
        {
            if (slowDownInitiate == true)
            {
            slowDownThereBuster = true;         
            Time.timeScale = slowDownFactor;
            Time.fixedDeltaTime = Time.timeScale * 0.02f;
            //Debug.Log("stamin up");
            }
           
        }
        else 
        {
            slowDownThereBuster = false; 
            Time.timeScale = 1;
            slowDownFactor = 1;
        }

        movingThing.Translate(scrollSpeed * Time.deltaTime, 0f, 0f);
    }

    void FixedUpdate()
    {
        if (slowDownThereBuster == true)
        {
             if (slowDownFactor > 0.2f)
             {
                    slowDownFactor -= 0.04f;
             }
          
                        
        }
       
    }

    void OnMouseOver()
    {
        slowDownInitiate = true; 
    }

    void OnMouseExit()
    {
        slowDownInitiate = false;
        slowDownThereBuster = false;
    }

    void OnMouseDown()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = mainCamera.nearClipPlane;
        worldPosition = mainCamera.ScreenToWorldPoint(mousePos);

        float size = 0.5f;

        //clickPoint -= transform.position;

        int xCount = Mathf.RoundToInt(worldPosition.x / size);
        int yCount = Mathf.RoundToInt(worldPosition.y / size);
        int zCount = Mathf.RoundToInt(worldPosition.z / size);

        Vector3 result = new Vector3(
            (float)xCount * size,
            (float)yCount * size,
            (float)zCount * size);

        Instantiate(block1, result, transform.rotation, placedBlocks);
    }

    void PlaceCubeNear (Vector3 clickPoint)
    {
        float size = 0.5f;

        //clickPoint -= transform.position;

        int xCount = Mathf.RoundToInt(clickPoint.x / size);
        int yCount = Mathf.RoundToInt(clickPoint.y / size);
        int zCount = Mathf.RoundToInt(clickPoint.z / size);

        Vector3 result = new Vector3(
            (float)xCount * size,
            (float)yCount * size,
            (float)zCount * size);
    }
}
