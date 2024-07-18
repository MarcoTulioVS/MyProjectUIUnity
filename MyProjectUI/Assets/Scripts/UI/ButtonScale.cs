using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;
public class ButtonScale : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
    public float finalScale = 1.2f;
    public float scaleDuration = 0.1f;

    private Vector3 defaultScale;
    private Tween currentTween;

    private void Awake()
    {
        defaultScale = transform.localScale;
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        currentTween = transform.DOScale(defaultScale*finalScale,scaleDuration);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        currentTween.Kill();
        transform.localScale = defaultScale;
    }
}
