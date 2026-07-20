using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class BaseImage : MonoBehaviour
{
    [Header("下落速度")]
    public float fallspeed = 300f;
    private RectTransform rect;
    private float parentHeight;
    private float myHeight;
    private RectTransform parentRect;
    void Start()
    {
        rect = GetComponent<RectTransform>();
        
        parentRect = transform.parent as RectTransform;
        parentHeight = parentRect.rect.height;
        myHeight = rect.rect.height; // 获取自己卡片的高度

    }
    void Update()
    {
        rect.anchoredPosition -= new Vector2(0, fallspeed * Time.deltaTime);
        if (rect.anchoredPosition.y <= -parentHeight / 2 + -myHeight / 2)
        {
            rect.anchoredPosition = new Vector2(0, parentHeight / 2 + myHeight / 2);
        }
    }


}
