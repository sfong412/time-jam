using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacedBlockShadow : MonoBehaviour
{
    Transform transform;
    SpriteRenderer spriteRenderer;

    public Sprite horizontalBlock;
    public Sprite verticalBlock;
    public Sprite rightTriangleBlock;
    public Sprite leftTriangleBlock;
    public Sprite cageBlock;

    Camera mainCamera;
    UIThings2 selector;

    Vector3 worldPosition;

    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
        spriteRenderer = GetComponent<SpriteRenderer>();

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
        int zCount = Mathf.RoundToInt(worldPosition.z / size);

        Vector3 result = new Vector3(
            (float)xCount * size,
            (float)yCount * size,
            (float)zCount * size);

        transform.position = result;

        changeSprite();
    }

    void changeSprite()
    {
        switch (selector.blockType)
        {
            case 1:
                transform.localScale = new Vector3(7.27f, 5.23f, 1f);
                spriteRenderer.sprite = horizontalBlock;
                break;
            //case 2 and case 3 are reversed because the selectors are flipped.
            case 2:
                transform.localScale = new Vector3(4f, 4f, 1f);
                spriteRenderer.sprite = rightTriangleBlock;
                break;
            case 3:
                transform.localScale = new Vector3(5.08f, 5.5f, 1f);
                spriteRenderer.sprite = verticalBlock;
                break;
            case 4:
                transform.localScale = new Vector3(4f, 4f, 1f);
                spriteRenderer.sprite = leftTriangleBlock;
                break;
            case 5:
                transform.localScale = new Vector3(7f, 7f, 1f);
                spriteRenderer.sprite = cageBlock;
                break;
        }
    }
}
