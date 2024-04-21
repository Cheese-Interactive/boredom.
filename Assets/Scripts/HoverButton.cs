using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverButton : MonoBehaviour {

    [Header("References")]
    [SerializeField] private TMP_Text text;

    [Header("Animations")]
    [SerializeField] private Color hoverColor;
    [SerializeField] private float hoverFadeDuration;
    private Color startColor;

    private void Start() {

        EventTrigger eventTriggers = gameObject.AddComponent<EventTrigger>();

        EventTrigger.Entry entry1 = new EventTrigger.Entry();
        entry1.eventID = EventTriggerType.PointerEnter;
        entry1.callback.AddListener((data) => OnPointerEnter((PointerEventData) data));

        EventTrigger.Entry entry2 = new EventTrigger.Entry();
        entry2.eventID = EventTriggerType.PointerExit;
        entry2.callback.AddListener((data) => OnPointerExit((PointerEventData) data));

        eventTriggers.triggers.Add(entry1);
        eventTriggers.triggers.Add(entry2);

        startColor = text.color;

    }

    private void OnDisable() {

        text.DOColor(startColor, hoverFadeDuration); // reset color

    }

    private void OnPointerEnter(PointerEventData eventData) {

        text.DOColor(hoverColor, hoverFadeDuration); // color transition

    }

    private void OnPointerExit(PointerEventData eventData) {

        text.DOColor(startColor, hoverFadeDuration); // color transition

    }
}
