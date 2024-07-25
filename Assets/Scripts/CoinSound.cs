using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSound : MonoBehaviour
{
    public static CoinSound instance;
    public AudioSource coinSource;
    public AudioClip coinSound;
    private void Awake()
    {
        if (instance == null) 
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        coinSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
