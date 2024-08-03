using UnityEngine;
using TMPro;

public class CreditsRoll : MonoBehaviour
{
    public float scrollSpeed = 30f;  // Adjust the speed as needed

    private RectTransform rectTransform;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    void Update()
    {
        rectTransform.anchoredPosition += new Vector2(0, scrollSpeed * Time.deltaTime);

        // Optional: Reset position or stop scrolling after a certain point
        if (rectTransform.anchoredPosition.y > Screen.height + rectTransform.rect.height)
        {
            rectTransform.anchoredPosition = new Vector2(rectTransform.anchoredPosition.x, -rectTransform.rect.height);
        }
    }
}
