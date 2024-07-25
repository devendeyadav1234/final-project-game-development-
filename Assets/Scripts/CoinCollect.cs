using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinCollect : MonoBehaviour
{
    public int scoreValue = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CoinSound.instance.coinSource.PlayOneShot(CoinSound.instance.coinSound);
            ScoreManager.instance.AddScore(1); 
            Destroy(gameObject); 
        }
    }
}
