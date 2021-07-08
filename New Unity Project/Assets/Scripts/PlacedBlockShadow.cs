using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacedBlockShadow : MonoBehaviour
{
    Transform transform;
    SpriteRenderer spriteRenderer;

    UIThings3 ink;
    Gameplay gameplay;

    public Sprite horizontalBlock;
    public Sprite verticalBlock;
    public Sprite rightTriangleBlock;
    public Sprite leftTriangleBlock;
    public Sprite cageBlock;

    public Sprite jumpPadBlock;

    public Sprite heavyBlock;

    public Sprite iceBlock;

    public Sprite alertBlock;


    public bool ableToPlace = true;

    Camera mainCamera;
    UIThings2 selector;

    Vector3 worldPosition;

    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        ink = GameObject.Find("Ink Bar").GetComponent<UIThings3>();
        gameplay = GameObject.Find("Gameplay Manager").GetComponent<Gameplay>();

        mainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        selector = GameObject.Find("Selectors").GetComponent<UIThings2>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = mainCamera.nearClipPlane;
        worldPosition = mainCamera.ScreenToWorldPoint(mousePos);

        float size = 0.5f;

        //clickPoint -= transform.position;

        int xCount = Mathf.RoundToInt(worldPosition.x / size);
        int yCount = Mathf.RoundToInt(worldPosition.y / size);
        //int zCount = Mathf.RoundToInt(worldPosition.z / size);

        Vector3 result = new Vector3(
            (float)xCount * size,
            (float)yCount * size,
            -6f);

        transform.position = result;

        changeSprite();
    }

    void changeSprite()
    {
        if (ink.remainingHealth >= gameplay.currentInkCost && ableToPlace == true)
        {
            spriteRenderer.color = new Color(0.42f, 1f, 0.56f, 0.35f);
        }
        else
        {
            spriteRenderer.color = new Color(0.78f, 0.01f, 0.06f, 0.35f);
        }

        switch (UIThings2.blockType)
        {
            case 1:
                transform.localScale = new Vector3(7.27f, 5.23f, 1f);
                transform.localRotation = Quaternion.Euler(0, 0, 0);
                spriteRenderer.sprite = horizontalBlock;
                break;
            case 2:
                transform.localScale = new Vector3(5.08f, 5.5f, 1f);
                transform.localRotation = Quaternion.Euler(0, 0, 0);
                spriteRenderer.sprite = verticalBlock;
                break;
            case 3:
                transform.localScale = new Vector3(4f, 4f, 1f);
                transform.localRotation = Quaternion.Euler(0, 0, 0);
                spriteRenderer.sprite = rightTriangleBlock;
                break;
            case 4:
                transform.localScale = new Vector3(4f, 4f, 1f);
                transform.localRotation = Quaternion.Euler(0, 0, 0);
                spriteRenderer.sprite = leftTriangleBlock;
                break;
            case 5:
                transform.localScale = new Vector3(7f, 7f, 1f);
                transform.localRotation = Quaternion.Euler(0, 0, 0);
                spriteRenderer.sprite = cageBlock;
                break;
            case 6:
                transform.localScale = new Vector3(6f, 6f, 1f);
                transform.localRotation = Quaternion.Euler(0, 0, 0);
                spriteRenderer.sprite = jumpPadBlock;
                break;
            case 7:
                transform.localScale = new Vector3(5f, 5f, 1f);
                transform.localRotation = Quaternion.Euler(0, 0, 0);
                spriteRenderer.sprite = heavyBlock;
                break;
            case 8:
                transform.localScale = new Vector3(4f, 4f, 1f);
                transform.localRotation = Quaternion.Euler(0, 0, 0);
                spriteRenderer.sprite = iceBlock;
                break;
            case 9:
                transform.localScale = new Vector3(4f, 4f, 1f);
                transform.localRotation = Quaternion.Euler(0, 0, 0);
                spriteRenderer.sprite = alertBlock;
                break;
        }
    }
}
