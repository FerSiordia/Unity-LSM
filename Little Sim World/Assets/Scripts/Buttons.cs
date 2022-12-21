using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public MoneyControl ADMoney;

    public GameObject panelOutOfMoney;
    public GameObject panelShirts;
    public GameObject panelHair;
    public GameObject panelPants;
    public GameObject panelMenu;
    public GameObject pantalon1;
    public GameObject pantalon2;
    public GameObject pantalon3;
    public GameObject pantalon4;
    public GameObject pantalon5;
    public GameObject pantalon6;
    public GameObject shirt1;
    public GameObject shirt2;
    public GameObject shirt3;
    public GameObject shirt4;
    public GameObject shirt5;
    public GameObject shirt6;
    public GameObject hair1;
    public GameObject hair2;
    public GameObject hair3;
    public GameObject hair4;
    public GameObject hair5;
    public GameObject hair6;

    // Start is called before the first frame update
    void Start()
    {
        panelMenu.SetActive(false);
        panelHair.SetActive(false);
        panelShirts.SetActive(false);
        panelPants.SetActive(false);
        panelOutOfMoney.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GoToShirts()
    {
        panelMenu.SetActive(false);
        panelShirts.SetActive(true);

    }
    public void GoToHair()
    {
        panelMenu.SetActive(false);
        panelHair.SetActive(true);
    }
    public void GoToPants()
    {
        panelMenu.SetActive(false);
        panelPants.SetActive(true);
    }
    public void GoToMenu()
    {
        panelMenu.SetActive(true);
        panelShirts.SetActive(false);
        panelPants.SetActive(false);
        panelHair.SetActive(false);
        panelOutOfMoney.SetActive(false);

    }
    public void ElegirPantalon1()
    {
        if (ADMoney.money >= 45)
        {
            ADMoney.AddOrDecreaseMoney(-45);
            pantalon1.SetActive(true);
            pantalon2.SetActive(false);
            pantalon3.SetActive(false);
            pantalon4.SetActive(false);
            pantalon5.SetActive(false);
            pantalon6.SetActive(false);
            panelMenu.SetActive(false);
            panelHair.SetActive(false);
            panelShirts.SetActive(false);
            panelPants.SetActive(false);
            panelOutOfMoney.SetActive(false);
        }
        else
        {
            panelOutOfMoney.SetActive(true);
            


        }
    }
    public void ElegirPantalon2()
    {
        if (ADMoney.money >= 45)
        {
            ADMoney.AddOrDecreaseMoney(-45);
            pantalon1.SetActive(false);
            pantalon2.SetActive(true);
            pantalon3.SetActive(false);
            pantalon4.SetActive(false);
            pantalon5.SetActive(false);
            pantalon6.SetActive(false);
            panelMenu.SetActive(false);
            panelHair.SetActive(false);
            panelShirts.SetActive(false);
            panelPants.SetActive(false);
            panelOutOfMoney.SetActive(false);
            
        }
        else
        {
            panelOutOfMoney.SetActive(true);
            Object.Destroy(panelOutOfMoney, 1.0f);
        }

    }
    public void ElegirPantalon3()
    {
        if (ADMoney.money >= 45)
        {
            ADMoney.AddOrDecreaseMoney(-45);
            pantalon1.SetActive(false);
            pantalon2.SetActive(false);
            pantalon3.SetActive(true);
            pantalon4.SetActive(false);
            pantalon5.SetActive(false);
            pantalon6.SetActive(false);
            panelMenu.SetActive(false);
            panelHair.SetActive(false);
            panelShirts.SetActive(false);
            panelPants.SetActive(false);
            panelOutOfMoney.SetActive(false);
        }
        else{
            panelOutOfMoney.SetActive(true);
            Object.Destroy(panelOutOfMoney, 1.0f);
        }
    }
    public void ElegirPantalon4()
    {
        if (ADMoney.money >= 55)
        {
            ADMoney.AddOrDecreaseMoney(-55);
            pantalon1.SetActive(false);
            pantalon2.SetActive(false);
            pantalon3.SetActive(false);
            pantalon4.SetActive(true);
            pantalon5.SetActive(false);
            pantalon6.SetActive(false);
            panelMenu.SetActive(false);
            panelHair.SetActive(false);
            panelShirts.SetActive(false);
            panelPants.SetActive(false);
            panelOutOfMoney.SetActive(false);
        }
        else{
            panelOutOfMoney.SetActive(true);
            Object.Destroy(panelOutOfMoney, 1.0f);
        }
    }
    public void ElegirPantalon5()
    {
        if (ADMoney.money >= 55)
        {
            ADMoney.AddOrDecreaseMoney(-55);
            pantalon1.SetActive(false);
            pantalon2.SetActive(false);
            pantalon3.SetActive(false);
            pantalon4.SetActive(false);
            pantalon5.SetActive(true);
            pantalon6.SetActive(false);
            panelMenu.SetActive(false);
            panelHair.SetActive(false);
            panelShirts.SetActive(false);
            panelPants.SetActive(false);
            panelOutOfMoney.SetActive(false);
        }
        else
        {
            panelOutOfMoney.SetActive(true);
            Object.Destroy(panelOutOfMoney, 1.0f);
        }
    }
    public void ElegirPantalon6()
    {
        if (ADMoney.money >= 55)
        {
            ADMoney.AddOrDecreaseMoney(-55);
            pantalon1.SetActive(false);
            pantalon2.SetActive(false);
            pantalon3.SetActive(false);
            pantalon4.SetActive(false);
            pantalon5.SetActive(false);
            pantalon6.SetActive(true);
            panelMenu.SetActive(false);
            panelHair.SetActive(false);
            panelShirts.SetActive(false);
            panelPants.SetActive(false);
            panelOutOfMoney.SetActive(false);
        }
        else
        {
            panelOutOfMoney.SetActive(true);
            Object.Destroy(panelOutOfMoney, 1.0f);
        }
    }
    public void ChooseShirt1()
    {
        if (ADMoney.money >= 45)
        {
            ADMoney.AddOrDecreaseMoney(-45);
            shirt1.SetActive(true);
            shirt2.SetActive(false);
            shirt3.SetActive(false);
            shirt4.SetActive(false);
            shirt5.SetActive(false);
            shirt6.SetActive(false);
            panelMenu.SetActive(false);
            panelHair.SetActive(false);
            panelShirts.SetActive(false);
            panelPants.SetActive(false);
            panelOutOfMoney.SetActive(false);
        }
        else
        {
            panelOutOfMoney.SetActive(true);
            Object.Destroy(panelOutOfMoney, 1.0f);
        }
    }
    public void ChooseShirt2()
    {
        if (ADMoney.money >= 45)
        {
            ADMoney.AddOrDecreaseMoney(-45);
            shirt1.SetActive(false);
            shirt2.SetActive(true);
            shirt3.SetActive(false);
            shirt4.SetActive(false);
            shirt5.SetActive(false);
            shirt6.SetActive(false);
            panelMenu.SetActive(false);
            panelHair.SetActive(false);
            panelShirts.SetActive(false);
            panelPants.SetActive(false);
            panelOutOfMoney.SetActive(false);
        }
        else
        {
            panelOutOfMoney.SetActive(true);
            Object.Destroy(panelOutOfMoney, 1.0f);
        }
    }
    public void ChooseShirt3()
    {
        if (ADMoney.money >= 45)
        {
            ADMoney.AddOrDecreaseMoney(-45);
            shirt1.SetActive(false);
            shirt2.SetActive(false);
            shirt3.SetActive(true);
            shirt4.SetActive(false);
            shirt5.SetActive(false);
            shirt6.SetActive(false);
            panelMenu.SetActive(false);
            panelHair.SetActive(false);
            panelShirts.SetActive(false);
            panelPants.SetActive(false);
            panelOutOfMoney.SetActive(false);
        }
        else
        {
            panelOutOfMoney.SetActive(true);
            Object.Destroy(panelOutOfMoney, 1.0f);
        }
    }
    public void ChooseShirt4()
    {
        if (ADMoney.money >= 55)
        {
            ADMoney.AddOrDecreaseMoney(-55);
            shirt1.SetActive(false);
            shirt2.SetActive(false);
            shirt3.SetActive(false);
            shirt4.SetActive(true);
            shirt5.SetActive(false);
            shirt6.SetActive(false);
            panelMenu.SetActive(false);
            panelHair.SetActive(false);
            panelShirts.SetActive(false);
            panelPants.SetActive(false);
            panelOutOfMoney.SetActive(false);
        }
        else
        {
            panelOutOfMoney.SetActive(true);
            Object.Destroy(panelOutOfMoney, 1.0f);
        }
    }
    public void ChooseShirt5()
    {
        if (ADMoney.money >= 55)
        {
            ADMoney.AddOrDecreaseMoney(-55);
            shirt1.SetActive(false);
            shirt2.SetActive(false);
            shirt3.SetActive(false);
            shirt4.SetActive(false);
            shirt5.SetActive(true);
            shirt6.SetActive(false);
            panelMenu.SetActive(false);
            panelHair.SetActive(false);
            panelShirts.SetActive(false);
            panelPants.SetActive(false);
            panelOutOfMoney.SetActive(false);
        }
        else
        {
            panelOutOfMoney.SetActive(true);
            Object.Destroy(panelOutOfMoney, 1.0f);
        }
    }
    public void ChooseShirt6()
    {
        if (ADMoney.money >= 55)
        {
            ADMoney.AddOrDecreaseMoney(-55);

            shirt1.SetActive(false);
            shirt2.SetActive(false);
            shirt3.SetActive(false);
            shirt4.SetActive(false);
            shirt5.SetActive(false);
            shirt6.SetActive(true);
            panelMenu.SetActive(false);
            panelHair.SetActive(false);
            panelShirts.SetActive(false);
            panelPants.SetActive(false);
            panelOutOfMoney.SetActive(false);
        }
        else
        {
            panelOutOfMoney.SetActive(true);
            Object.Destroy(panelOutOfMoney, 1.0f);
        }
    }
    public void ChooseHair1()
    {
        if (ADMoney.money >= 25)
        {
            ADMoney.AddOrDecreaseMoney(-25);

            hair1.SetActive(true);
            hair2.SetActive(false);
            hair3.SetActive(false);
            hair4.SetActive(false);
            hair5.SetActive(false);
            hair6.SetActive(false);
            panelMenu.SetActive(false);
            panelHair.SetActive(false);
            panelShirts.SetActive(false);
            panelPants.SetActive(false);
            panelOutOfMoney.SetActive(false);
        }
        else
        {
            panelOutOfMoney.SetActive(true);
            Object.Destroy(panelOutOfMoney, 1.0f);
        }
    }
    public void ChooseHair2()
    {
        if (ADMoney.money >= 25)
        {
            ADMoney.AddOrDecreaseMoney(-25);

            hair1.SetActive(false);
            hair2.SetActive(true);
            hair3.SetActive(false);
            hair4.SetActive(false);
            hair5.SetActive(false);
            hair6.SetActive(false);
            panelMenu.SetActive(false);
            panelHair.SetActive(false);
            panelShirts.SetActive(false);
            panelPants.SetActive(false);
            panelOutOfMoney.SetActive(false);
        }
        else
        {
            panelOutOfMoney.SetActive(true);
            Object.Destroy(panelOutOfMoney, 1.0f);
        }
    }
    public void ChooseHair3()
    {
        if (ADMoney.money >= 25)
        {
            ADMoney.AddOrDecreaseMoney(-35);

            hair1.SetActive(false);
            hair2.SetActive(false);
            hair3.SetActive(true);
            hair4.SetActive(false);
            hair5.SetActive(false);
            hair6.SetActive(false);
            panelMenu.SetActive(false);
            panelHair.SetActive(false);
            panelShirts.SetActive(false);
            panelPants.SetActive(false);
            panelOutOfMoney.SetActive(false);
        }
        else
        {
            panelOutOfMoney.SetActive(true);
            Object.Destroy(panelOutOfMoney, 1.0f);
        }
    }
    public void ChooseHair4()
    {
        if (ADMoney.money >= 35)
        {
            ADMoney.AddOrDecreaseMoney(-35);

            hair1.SetActive(false);
            hair2.SetActive(false);
            hair3.SetActive(false);
            hair4.SetActive(true);
            hair5.SetActive(false);
            hair6.SetActive(false);
            panelMenu.SetActive(false);
            panelHair.SetActive(false);
            panelShirts.SetActive(false);
            panelPants.SetActive(false);
            panelOutOfMoney.SetActive(false);
            

        }
        else
        {
            panelOutOfMoney.SetActive(true);
            Object.Destroy(panelOutOfMoney, 1.0f);
        }
    }
    public void ChooseHair5()
    {
        if (ADMoney.money >= 35)
        {
            ADMoney.AddOrDecreaseMoney(-35);

            hair1.SetActive(false);
            hair2.SetActive(false);
            hair3.SetActive(false);
            hair4.SetActive(false);
            hair5.SetActive(true);
            hair6.SetActive(false);
            panelMenu.SetActive(false);
            panelHair.SetActive(false);
            panelShirts.SetActive(false);
            panelPants.SetActive(false);
            panelOutOfMoney.SetActive(false);
            Debug.Log(ADMoney.money);
        }
        else
        {
            panelOutOfMoney.SetActive(true);
            Object.Destroy(panelOutOfMoney, 1.0f);
        }
    }
    public void ChooseHair6()
    {
        Debug.Log(ADMoney.money);
        if (ADMoney.money >= 35)
        {
            ADMoney.AddOrDecreaseMoney(-35);
        

            hair1.SetActive(false);
            hair2.SetActive(false);
            hair3.SetActive(false);
            hair4.SetActive(false);
            hair5.SetActive(false);
            hair6.SetActive(true);
            panelMenu.SetActive(false);
            panelHair.SetActive(false);
            panelShirts.SetActive(false);
            panelPants.SetActive(false);
            panelOutOfMoney.SetActive(false);
            Debug.Log(ADMoney.money);
        }
        else
        {
            panelOutOfMoney.SetActive(true);
            Object.Destroy(panelOutOfMoney, 1.0f);
        }
       

    }
}
