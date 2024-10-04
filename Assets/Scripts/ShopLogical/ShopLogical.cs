using UnityEngine;
using UnityEngine.UI;

public class ShopLogical : MonoBehaviour
{
    private bool IsOpenShop = false;
    private CoinLogical _coinLogical;
    [SerializeField] GameObject Canvas;

  private void ShopOpen()
    {
        IsOpenShop = true;
        if (IsOpenShop == true)
        {
            Canvas.SetActive(true);
        }
        else
            Canvas.SetActive(false);
    }




   private enum Tovar
    {
        height, Maneuverability
    }

    private enum Abilities
    {
        Jerk_down, Slowing, Shield
    }

    private enum Lvl
    {
        One, two, three, four, five
    }





}