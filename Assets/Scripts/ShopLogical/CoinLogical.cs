using UnityEngine;
using UniRx;

public class CoinLogical : MonoBehaviour
{
    public static IntReactiveProperty Coin = new IntReactiveProperty (1000);
    [SerializeField] private GameObject Data;



    private void AddCoin() { Coin.Value ++; }
    private void DoubleCoin() { Coin.Value *=2; }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("CatchCoin"))
        {
            AddCoin();
            Destroy(other.gameObject);
         
        }

        if (other.CompareTag("DoubleCoins"))
        {
            DoubleCoin();
            Destroy(other.gameObject);


        }
    }

}
