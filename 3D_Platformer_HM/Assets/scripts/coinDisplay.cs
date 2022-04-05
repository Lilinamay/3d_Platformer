using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//display total coins
public class coinDisplay : MonoBehaviour
{
    public int totalC = 0;    //total coins
    public TMP_Text coinText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = "Coin: " + totalC;      //coin display
        
    }
}
