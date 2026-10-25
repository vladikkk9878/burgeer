using System;
using UnityEngine;

public class BurgerChecker : MonoBehaviour
{
    void Start()
    {
        string burgerResult;

        CheckBurger("огурец", "кетчуп", "сыр", "котлета", out burgerResult);
        Debug.Log($"[Тест 1] Результат: {burgerResult}");

       
        CheckBurger("булочка с кунжутом", "две котлеты", "сыр", "специальный соус", out burgerResult);
        Debug.Log($"[Тест 2] Результат: {burgerResult}");

        CheckBurger("огурцы", "салат", "лук", "булочка", out burgerResult);
        Debug.Log($"[Тест 3] Результат: {burgerResult}");
    }

    public void CheckBurger(string ing1, string ing2, string ing3, string ing4, out string result)
    {

        string[] inputIngredients = { ing1, ing2, ing3, ing4 };

        string[] cheeseburgerRecipe = { "сыр", "кетчуп", "котлета", "огурец" };
        string[] bigMacRecipe = { "специальный соус", "булочка с кунжутом", "две котлеты" };


        int cheeseburgerMatches = 0;
        int bigMacMatches = 0;

        foreach (string ingredient in inputIngredients)
        {

            if (Array.Exists(cheeseburgerRecipe, element => element == ingredient))
            {
                cheeseburgerMatches++;
            }

            if (Array.Exists(bigMacRecipe, element => element == ingredient))
            {
                bigMacMatches++;
            }
        }

        if (cheeseburgerMatches == cheeseburgerRecipe.Length)
        {
            result = "чизбургер";
        }
        else if (bigMacMatches == bigMacRecipe.Length)
        {
            result = "биг мак";
        }
        else
        {
            result = "Неизвестный бургер (ингредиенты не совпали)";
        }
    }
}
