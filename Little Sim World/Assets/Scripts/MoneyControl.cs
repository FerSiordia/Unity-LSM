using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyControl : MonoBehaviour
{
    //public TextMesh txtMoney;
    public int money;
    // Start is called before the first frame update
    void Start()
    {
        money = 120;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddOrDecreaseMoney(int amount)
    {
        money += amount;
    }
}
