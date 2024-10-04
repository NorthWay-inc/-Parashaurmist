using UnityEngine;

public class CoinLogical : MonoBehaviour
{
    [SerializeField] public int Coin = 0;



    private void AddCoin() { Coin++; }
    private void DoubleCoin() { Coin*=2; }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("CatchCoin"))
        {
            AddCoin();
            Destroy(other.gameObject);
            Debug.Log("1");
        }

        if (other.CompareTag("DoubleCoins"))
        {
            DoubleCoin();
            Destroy(other.gameObject);
            Debug.Log("2");

        }
    }

}
