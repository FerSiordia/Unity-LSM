using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyControl : MonoBehaviour
{
    
    public int money;
    public TMP_Text txtMoney;
    
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {

        txtMoney.SetText(money.ToString());
    }
    public void AddOrDecreaseMoney(int amount)
    {
        money += amount;
    }
}
