using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;




public class ShopLogical : MonoBehaviour
{

    [HideInInspector] public int LvlHeight = 0, LvlCountCoin = 0, LvlManeuverability = 0, BuyCountH = 10, BuyCountM = 10, BuyCountC = 10, BuyCount = 30;
    [HideInInspector] public bool Jerk_down, Slowing, Shield;
    [SerializeField] GameObject ShopObj;
    public Text text;

    private void Awake()
    {
        text = text.GetComponent<Text>();
        
    }

    private void Update()
    {
        
        text.text = CoinLogical.Coin.ToString();
    }



    public void BuyHeight()
    {
        Debug.Log("BuyHeight");
        if ((CoinLogical.Coin >= BuyCountH || CoinLogical.Coin == BuyCountH) && LvlHeight < 5)
        {
            CoinLogical.Coin -= BuyCountH;
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
        
        if ((CoinLogical.Coin  >= BuyCountM || CoinLogical.Coin == BuyCountM) && LvlManeuverability < 5)
        {
            CoinLogical.Coin -= BuyCountM;
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
        if ((CoinLogical.Coin >= BuyCountC || CoinLogical.Coin == BuyCountC) && LvlCountCoin < 5)
        {
            CoinLogical.Coin -= BuyCountC;
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
        //� ���� ������ ���� ������  ���� Jerk_down == 1 �� �� ������ ����� ���-�� � �������
        if ((CoinLogical.Coin >= BuyCount || CoinLogical.Coin == BuyCount) && Jerk_down == false)
        {
            CoinLogical.Coin -= BuyCountH;
            Jerk_down = true;
            Debug.Log("BuyJerk_down");

        }
    }
    public void BuySlowing()
    {
        //� ���� ������ ���� ������  ���� Slowing == true �� �� ������ ����� ���-�� � �������
        if ((CoinLogical.Coin >= BuyCount || CoinLogical.Coin == BuyCount) && Slowing == false)
        {
            CoinLogical.Coin -= BuyCountH;
            Slowing = true;
            Debug.Log("BuySlowing");
        }
    }  
    public void BuyShield()
    {
        //� ���� ������ ���� ������  ���� Shield == true �� �� ������ ����� ���-�� � �������
        if ((CoinLogical.Coin >= BuyCount || CoinLogical.Coin == BuyCount)&& Shield == false)
        {
            CoinLogical.Coin -= BuyCount;
            Shield = true;
            Debug.Log("BuyShield");
        }
    }
}