using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ShopLogical : MonoBehaviour
{
    [SerializeField] private bool IsOpenShop = true;
    /// <summary>
    /// 
    /// </summary>
   
    
    
    private int LvlH = 0;
    private int LvlM = 0;
    private int LvlC = 0;
    private int BuyCount = 10;
    [SerializeField] GameObject ShopObj;





    public void BuyHeight()
    {
        Debug.Log("BuyHeight");
        if ((CoinLogical.Coin >= BuyCount || CoinLogical.Coin == BuyCount) && LvlH < 5)
        {
            LvlH += 1;
            Data._height += 5;

            Debug.Log(LvlH+"lvl");

        }
        else if (LvlM == 5)
        {
            Debug.Log("Max lvl");
        }
    }
   
    public void BuyManeuverability()
    {
        Debug.Log("BuyManeuverability");
        
        if ((CoinLogical.Coin  >= BuyCount || CoinLogical.Coin == BuyCount) && LvlM < 5)
        {
            CoinLogical.Coin -= BuyCount;
            LvlM += 1;
            Data._maneuverability += 2; 
            Debug.Log(LvlM+"lvl");
        }
        else if (LvlM == 5)
        {
            Debug.Log("Max lvl");
        }
    } 
    public void BuyCountCoin()
    {
        Debug.Log("BuyCountCoin");
        if ((CoinLogical.Coin >= BuyCount || CoinLogical.Coin == BuyCount) && LvlC < 5)
        {
            LvlC += 1;
            Data._countCoin += 2;

            Debug.Log(LvlC+"lvl");

        }
        
        else if (LvlM == 5)
        {
            Debug.Log("Max lvl");
        }
    }
    public void BuyJerk_down()
    {
        if ((CoinLogical.Coin >= BuyCount || CoinLogical.Coin == BuyCount))
        {

        }
    }
    public void BuySlowing()
    {
        if ((CoinLogical.Coin >= BuyCount || CoinLogical.Coin == BuyCount))
        {

        }
    }  
    public void BuyShield()
    {
        if ((CoinLogical.Coin >= BuyCount || CoinLogical.Coin == BuyCount))
        {

        }
    }

    public void BuyIsShop()
    {
        if ((CoinLogical.Coin >= BuyCount || CoinLogical.Coin == BuyCount))
        {

        }
    }








}