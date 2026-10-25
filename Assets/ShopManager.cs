using System;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    [Header("UI элементы")]
    public Button nextDayButton;

    private string[] itemNames = { "Процессор", "Видеокарта", "Оперативная память", "Блок питания" };
    private float[] itemPrices = { 15000f, 45000f, 6000f, 5000f };

    void Start()
    {
        CalculateAndPrintCart(itemNames, itemPrices);

        if (nextDayButton != null)
        {
            nextDayButton.onClick.AddListener(OnNextDayPressed);
        }
    }

    // Метод 1: Принимает массивы string и float, считает сумму
    public void CalculateAndPrintCart(string[] names, float[] prices)
    {
        Debug.Log("--- СОДЕРЖИМОЕ КОРЗИНЫ ---");
        float totalPrice = 0f;

        for (int i = 0; i < names.Length; i++)
        {
            PrintField(name: names[i]);
            PrintField(price: prices[i]);

            totalPrice += prices[i];
        }

        Debug.Log($"ИТОГО К ОПЛАТЕ: {totalPrice} руб.");
        Debug.Log("---------------------------");
    }

    public void PrintField(string name = null, float price = -1f)
    {
        if (name != null)
        {
            Debug.Log($"Товар: {name}");
        }
        if (price >= 0f)
        {
            Debug.Log($"Стоимость: {price} руб.");
        }
    }
    private void OnNextDayPressed()
    {
        Debug.Log("<color=yellow>=== НАСТУПИЛ СЛЕДУЮЩИЙ ДЕНЬ (ЦЕНЫ УДВОЕНЫ) ===</color>");

        for (int i = 0; i < itemPrices.Length; i++)
        {
            itemPrices[i] *= 2;
        }
        CalculateAndPrintCart(itemNames, itemPrices);
    }
}
