using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class BaseImage : MonoBehaviour
{
    [Header("下落速度")]
    public float fallspeed = 300f;
    private RectTransform rect;
    void Start()
    {
        rect = GetComponent<RectTransform>();
    }
    void Update()
    {
        rect.anchoredPosition -= new Vector2(0, fallspeed * Time.deltaTime);
    }


}
