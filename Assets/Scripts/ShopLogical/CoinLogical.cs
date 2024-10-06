using UnityEngine;

public class CoinLogical : MonoBehaviour
{
    public static int Coin = 1000;



    private void AddCoin() { Coin++; }
    private void DoubleCoin() { Coin*=2; }


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
