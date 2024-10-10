using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;
using UniRx;




public class ShopLogical : MonoBehaviour
{

    [HideInInspector] public int LvlHeight = 0, LvlCountCoin = 0, LvlManeuverability = 0, BuyCount = 30;
    private  IntReactiveProperty BuyCountH = new (10);
    private IntReactiveProperty BuyCountM = new (12);
    private  IntReactiveProperty BuyCountC = new (15);
    [HideInInspector] public bool Jerk_down, Slowing, Shield;
    [SerializeField] GameObject ShopObj;
    public TMP_Text text, TextManeuverability, TextHeight, TextCountCoin;


    private void Awake()
    {
        CoinLogical.Coin.Subscribe((many) => {
            text.text = many.ToString();
        } );

        BuyCountM.Subscribe((Maneuverability) =>
        {
            TextManeuverability.text = Maneuverability.ToString();
        });

        BuyCountH.Subscribe((Height) =>
        {
            TextHeight.text = Height.ToString();
        });

        BuyCountC.Subscribe((CountCoin) =>
        {
            TextCountCoin.text = CountCoin.ToString();
        });

    }

    public void BuyHeight()
    {
        if ((CoinLogical.Coin.Value >= BuyCountH.Value || CoinLogical.Coin.Value == BuyCountH.Value) && LvlHeight < 5)
        {
            CoinLogical.Coin.Value -= BuyCountH.Value;
            BuyCountH.Value += 5;
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
        
        if ((CoinLogical.Coin.Value  >= BuyCountM.Value || CoinLogical.Coin.Value == BuyCountM.Value) && LvlManeuverability < 5)
        {
            CoinLogical.Coin.Value -= BuyCountM.Value;
            BuyCountM.Value += 6;
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
        if ((CoinLogical.Coin.Value >= BuyCountC.Value || CoinLogical.Coin.Value == BuyCountC.Value) && LvlCountCoin < 5)
        {
            CoinLogical.Coin.Value -= BuyCountC.Value;
            BuyCountC.Value += 10;
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
        //У тебя должна быть логика  если Jerk_down == true то ты должен делат что-то с игроком
        if ((CoinLogical.Coin.Value >= BuyCount || CoinLogical.Coin.Value == BuyCount) && Jerk_down == false)
        {
            CoinLogical.Coin.Value -= BuyCountH.Value;
            Jerk_down = true;
            Debug.Log("BuyJerk_down");

        }
    }
    public void BuySlowing()
    {
        //У тебя должна быть логика  если Slowing == true то ты должен делат что-то с игроком
        if ((CoinLogical.Coin.Value >= BuyCount || CoinLogical.Coin.Value == BuyCount) && Slowing == false)
        {
            CoinLogical.Coin.Value -= BuyCount;
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