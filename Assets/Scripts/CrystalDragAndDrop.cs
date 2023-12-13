using UnityEngine;
using UnityEngine.EventSystems;

public class CrystalDragDrop : MonoBehaviour, IDragHandler, IEndDragHandler
{
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    private GameManager gameManager;

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        gameManager = FindObjectOfType<GameManager>();
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / FindObjectOfType<Canvas>().scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = true;

        // Provjerite kojoj je polici objekt najbliži
        int closestShelfIndex = FindClosestShelfIndex();

        // Postavite kristal na policu ako je igrač stavio na pravu policu
        if (closestShelfIndex != -1)
        {
            gameManager.PlaceCrystalOnShelf(closestShelfIndex);
            Destroy(gameObject);
        }
    }

    private int FindClosestShelfIndex()
    {
        float closestDistance = float.MaxValue;
        int closestIndex = -1;

        for (int i = 0; i < gameManager.shelves.Length; i++)
        {
            float distance = Vector3.Distance(transform.position, gameManager.shelves[i].transform.position);

            if (distance < closestDistance)
            {
                closestDistance = distance;
                closestIndex = i;
            }
        }

        return closestIndex;
    }
}
