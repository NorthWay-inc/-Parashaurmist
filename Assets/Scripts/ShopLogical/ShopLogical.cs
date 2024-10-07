using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;
using UniRx;




public class ShopLogical : MonoBehaviour
{

    [HideInInspector] public int LvlHeight = 0, LvlCountCoin = 0, LvlManeuverability = 0, BuyCountH = 10, BuyCountM = 10, BuyCountC = 10, BuyCount = 30;
    [HideInInspector] public bool Jerk_down, Slowing, Shield;
    [SerializeField] GameObject ShopObj;
    public TMP_Text text; 

    private void Awake()
    {
        text = text.GetComponent<TMP_Text>();
        CoinLogical.Coin.Subscribe((many) => {
            text.text = many.ToString();
        } );
    }

    public void BuyHeight()
    {
        Debug.Log("BuyHeight");
        if ((CoinLogical.Coin.Value >= BuyCountH || CoinLogical.Coin.Value == BuyCountH) && LvlHeight < 5)
        {
            CoinLogical.Coin.Value -= BuyCountH;
            BuyCountH += 5;
            LvlHeight += 1;
            Data._height += 5;
            Debug.Log(LvlHeight+"lvl");

        }
        else if (LvlManeuverability == 5)
        {
            Debug.Log("Max lvl");
        }
    }
   
    public void BuyManeuverability()
    {
        Debug.Log("BuyManeuverability");
        
        if ((CoinLogical.Coin.Value  >= BuyCountM || CoinLogical.Coin.Value == BuyCountM) && LvlManeuverability < 5)
        {
            CoinLogical.Coin.Value -= BuyCountM;
            BuyCountM += 6;
            LvlManeuverability += 1;
            Data._maneuverability += 2; 
            Debug.Log(LvlManeuverability+"lvl");
        }
        else if (LvlManeuverability == 5)
        {
            Debug.Log("Max lvl");
        }
    } 
    public void BuyCountCoin()
    {
        Debug.Log("BuyCountCoin");
        if ((CoinLogical.Coin.Value >= BuyCountC || CoinLogical.Coin.Value == BuyCountC) && LvlCountCoin < 5)
        {
            CoinLogical.Coin.Value -= BuyCountC;
            BuyCountC += 10;
            LvlCountCoin += 1;
            Data._countCoin += 2;
            Debug.Log(LvlCountCoin+"lvl");
        }
        
        else if (LvlManeuverability == 5)
        {
            Debug.Log("Max lvl");
        }
    }
    public void BuyJerk_down()
    {
        //У тебя должна быть логика  если Jerk_down == 1 то ты должен делат что-то с игроком
        if ((CoinLogical.Coin.Value >= BuyCount || CoinLogical.Coin.Value == BuyCount) && Jerk_down == false)
        {
            CoinLogical.Coin.Value -= BuyCountH;
            Jerk_down = true;
            Debug.Log("BuyJerk_down");

        }
    }
    public void BuySlowing()
    {
        //У тебя должна быть логика  если Slowing == true то ты должен делат что-то с игроком
        if ((CoinLogical.Coin.Value >= BuyCount || CoinLogical.Coin.Value == BuyCount) && Slowing == false)
        {
            CoinLogical.Coin.Value -= BuyCountH;
            Slowing = true;
            Debug.Log("BuySlowing");
        }
    }  
    public void BuyShield()
    {
        //У тебя должна быть логика  если Shield == true то ты должен делат что-то с игроком
        if ((CoinLogical.Coin.Value >= BuyCount || CoinLogical.Coin.Value == BuyCount)&& Shield == false)
        {
            CoinLogical.Coin.Value -= BuyCount;
            Shield = true;
            Debug.Log("BuyShield");
        }
    }
}