using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    Image clock;
    CanvasRenderer canvasRenderer;
    RectTransform rectTransform;
    float totalTime = GlobalVars.ultraSpeedTime;
    float time = 0f;
    float sizeX;
    float sizeY;

    private void Start()
    {
        clock = GetComponent<Image>();
        canvasRenderer = GetComponent<CanvasRenderer>();
        rectTransform = GetComponent<RectTransform>();
        sizeX = rectTransform.localScale.x;
        sizeY = rectTransform.localScale.y;
    }

    private void Update()
    {
        if(time < totalTime)
        {
            time += Time.deltaTime;
            clock.fillAmount = time / totalTime;
            rectTransform.localScale = new Vector3(sizeX + clock.fillAmount, sizeY + clock.fillAmount, rectTransform.localScale.z);
            canvasRenderer.SetAlpha(1f - clock.fillAmount);
        }
    }

}
