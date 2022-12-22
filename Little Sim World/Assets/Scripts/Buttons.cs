using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public MoneyControl ADMoney;
    private bool p1,p2,p3,p4,p5,p6,s1,s2,s3,s4,s5,s6,h1,h2,h3,h4,h5,h6=false; //We´ll use these variables to check if we already purchased something



    public GameObject Closet;
    public GameObject panelOwnedHair;
    public GameObject panelOwnedPants;
    public GameObject panelOwnedShirts;
    public GameObject panelOutOfMoney;
    public GameObject panelAlreadyInCloset;
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
     


    //Here we will show the purchased items
    public GameObject Ppantalon1;
    public GameObject Ppantalon2;
    public GameObject Ppantalon3;
    public GameObject Ppantalon4;
    public GameObject Ppantalon5;
    public GameObject Ppantalon6;
    public GameObject Pshirt1;
    public GameObject Pshirt2;
    public GameObject Pshirt3;
    public GameObject Pshirt4;
    public GameObject Pshirt5;
    public GameObject Pshirt6;
    public GameObject Phair1;
    public GameObject Phair2;
    public GameObject Phair3;
    public GameObject Phair4;
    public GameObject Phair5;
    public GameObject Phair6;

    // Start is called before the first frame update
    void Start()
    {
        panelMenu.SetActive(false);
        panelHair.SetActive(false);
        panelShirts.SetActive(false);
        panelPants.SetActive(false);
        panelOutOfMoney.SetActive(false);
        panelOwnedHair.SetActive(false);
        panelOwnedShirts.SetActive(false);
        panelOwnedPants.SetActive(false);
        Closet.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            CloseMenu();
        }
        if (p1 == true)
        {
            Ppantalon1.SetActive(true); 
        }
        if (p2 == true)
        {
            Ppantalon2.SetActive(true);
        }
        if (p3 == true)
        {
            Ppantalon3.SetActive(true);
        }
        if (p4 == true)
        {
            Ppantalon4.SetActive(true);
        }
        if (p5 == true)
        {
            Ppantalon5.SetActive(true);
        }
        if (p6 == true)
        {
            Ppantalon6.SetActive(true);
        }
        if (s1 == true)
        {
            Pshirt1.SetActive(true);
        }
        if (s2 == true)
        {
            Pshirt2.SetActive(true);
        }
        if (s3 == true)
        {
            Pshirt3.SetActive(true);
        }
        if (s4 == true)
        {
            Pshirt4.SetActive(true);
        }
        if (s5 == true)
        {
            Pshirt5.SetActive(true);
        }
        if (s6 == true)
        {
            Pshirt6.SetActive(true);
        }
    }

    public void GoToCloset()
    {
        panelMenu.SetActive(false);
        panelHair.SetActive(false);
        panelShirts.SetActive(false);
        panelPants.SetActive(false);
        panelOutOfMoney.SetActive(false);
        panelOwnedHair.SetActive(false);
        panelOwnedShirts.SetActive(false);
        panelOwnedPants.SetActive(false);
        Closet.SetActive(true);

    }

    public void CloseMenu()
    {
        panelMenu.SetActive(false);
        panelHair.SetActive(false);
        panelShirts.SetActive(false);
        panelPants.SetActive(false);
        panelOutOfMoney.SetActive(false);
        panelOwnedHair.SetActive(false);
        panelOwnedShirts.SetActive(false);
        panelOwnedPants.SetActive(false);
        Closet.SetActive(false);
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
    //For the closet
    public void GoToOwnedPants()
    {
        panelMenu.SetActive(false);
        panelOwnedPants.SetActive(true);
    }
    public void GoToOwnedHair()
    {
        panelMenu.SetActive(false);
        panelOwnedHair.SetActive(true);
    }
    public void GoToOwnedShirts()
    {
        panelMenu.SetActive(false);
        panelOwnedShirts.SetActive(true);
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
        if (ADMoney.money >= 45 && p1==false)
        {
            ADMoney.AddOrDecreaseMoney(-45);
            p1 = true;
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
        else if(p1==true)
        {
            panelAlreadyInCloset.SetActive(true);
            StartCoroutine(WaitSeconds());
            p1 = true;

        }
        else
        {
            panelOutOfMoney.SetActive(true);
            StartCoroutine(WaitSeconds());
        }
    }
    public void ElegirPantalon2()
    {
        if (ADMoney.money >= 45 && p2==false)
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
            p2 = true;
        }
        else if (p2 == true)
        {
            panelAlreadyInCloset.SetActive(true);
            StartCoroutine(WaitSeconds());
            

        }
        else
        {
            panelOutOfMoney.SetActive(true);
            StartCoroutine(WaitSeconds());
        }

    }
    public void ElegirPantalon3()
    {
        if (ADMoney.money >= 45 && p3==false)
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
            p3 = true;
        }
        else if (p3 == true)
        {
            panelAlreadyInCloset.SetActive(true);
            StartCoroutine(WaitSeconds());
            p3 = true;

        }
        else
        {
            panelOutOfMoney.SetActive(true);
            StartCoroutine(WaitSeconds());
        }
    }
    public void ElegirPantalon4()
    {
        if (ADMoney.money >= 55 && p4==false)
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
            p4 = true;
        }
        else if (p4 == true)
        {
            panelAlreadyInCloset.SetActive(true);
            StartCoroutine(WaitSeconds());
            p4 = true;

        }
        else
        {
            panelOutOfMoney.SetActive(true);
            StartCoroutine(WaitSeconds());
        }
    }
    public void ElegirPantalon5()
    {
        if (ADMoney.money >= 55 && p5==false)
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
            p5 = true;
        }
        else if (p5 == true)
        {
            panelAlreadyInCloset.SetActive(true);
            StartCoroutine(WaitSeconds());
            p5 = true;

        }
        else
        {
            panelOutOfMoney.SetActive(true);
            StartCoroutine(WaitSeconds());
        }
    }
    public void ElegirPantalon6()
    {
        if (ADMoney.money >= 55 && p6==false)
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
            p6 = true;
        }
        else if (p6 == true)
        {
            panelAlreadyInCloset.SetActive(true);
            StartCoroutine(WaitSeconds());
            p6 = true;

        }
        else
        {
            panelOutOfMoney.SetActive(true);
            StartCoroutine(WaitSeconds());
        }
    }
    public void ChooseShirt1()
    {
        if (ADMoney.money >= 45 && s1==false)
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
            s1 = true;
        }
        else if (s1 == true)
        {
            panelAlreadyInCloset.SetActive(true);
            StartCoroutine(WaitSeconds());
            s1 = true;

        }
        else
        {
            panelOutOfMoney.SetActive(true);
            StartCoroutine(WaitSeconds());
        }
    }
    public void ChooseShirt2()
    {
        if (ADMoney.money >= 45 && s2==false)
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
            s2 = true;
        }
        else if (s2 == true)
        {
            panelAlreadyInCloset.SetActive(true);
            StartCoroutine(WaitSeconds());
        }
        else
        {
            panelOutOfMoney.SetActive(true);
            StartCoroutine(WaitSeconds());
        }
    }
    public void ChooseShirt3()
    {
        if (ADMoney.money >= 45 && s3==false)
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
            s3 = true;
        }
        else if (s3 == true)
        {
            panelAlreadyInCloset.SetActive(true);
            StartCoroutine(WaitSeconds());
        }
        else
        {
            panelOutOfMoney.SetActive(true);
            StartCoroutine(WaitSeconds());
        }
    }
    public void ChooseShirt4()
    {
        if (ADMoney.money >= 55 && s4==false)
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
            s4 = true;
        }
        else if (s4 == true)
        {
            panelAlreadyInCloset.SetActive(true);
            StartCoroutine(WaitSeconds());
        }
        else
        {
            panelOutOfMoney.SetActive(true);
            StartCoroutine(WaitSeconds());
        }
    }
    public void ChooseShirt5()
    {
        if (ADMoney.money >= 55 && s5==false)
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
            s5 = true;
        }
        else if (s5 == true)
        {
            panelAlreadyInCloset.SetActive(true);
            StartCoroutine(WaitSeconds());
        }
        else
        {
            panelOutOfMoney.SetActive(true);
            StartCoroutine(WaitSeconds());
        }
    }
    public void ChooseShirt6()
    {
        if (ADMoney.money >= 55 && s6==false)
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
            s6 = true;
        }
        else if (s6 == true)
        {
            panelAlreadyInCloset.SetActive(true);
            StartCoroutine(WaitSeconds());
        }
        else
        {
            panelOutOfMoney.SetActive(true);
            StartCoroutine(WaitSeconds());
        }
    }
    public void ChooseHair1()
    {
        if (ADMoney.money >= 25 && h1==false)
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
            h1 = true;
        }
        else if (h1 == true)
        {
            panelAlreadyInCloset.SetActive(true);
            StartCoroutine(WaitSeconds());
        }
        else
        {
            panelOutOfMoney.SetActive(true);
            StartCoroutine(WaitSeconds());
        }
    }
    public void ChooseHair2()
    {
        if (ADMoney.money >= 25 && h2==false)
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
            h2 = true;
        }
        else if (h2 == true)
        {
            panelAlreadyInCloset.SetActive(true);
            StartCoroutine(WaitSeconds());
        }
        else
        {
            panelOutOfMoney.SetActive(true);
            StartCoroutine(WaitSeconds());
        }
    }
    public void ChooseHair3()
    {
        if (ADMoney.money >= 25 && h3==false)
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
            h3 = true;
        }
        else if (h3 == true)
        {
            panelAlreadyInCloset.SetActive(true);
            StartCoroutine(WaitSeconds());
        }
        else
        {
            panelOutOfMoney.SetActive(true);
            StartCoroutine(WaitSeconds());
        }
    }
    public void ChooseHair4()
    {
        if (ADMoney.money >= 35 && h4==false)
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
            h4 = true;
            

        }
        else if (h4 == true)
        {
            panelAlreadyInCloset.SetActive(true);
            StartCoroutine(WaitSeconds());
        }
        else
        {
            panelOutOfMoney.SetActive(true);
            StartCoroutine(WaitSeconds());
        }
    }
    public void ChooseHair5()
    {
        if (ADMoney.money >= 35 && h5==false)
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
            h5 = true;
            Debug.Log(ADMoney.money);
        }
        else if (h5 == true)
        {
            panelAlreadyInCloset.SetActive(true);
            StartCoroutine(WaitSeconds());
        }
        else
        {
            panelOutOfMoney.SetActive(true);
            StartCoroutine(WaitSeconds());
        }
    }
    public void ChooseHair6()
    {
        Debug.Log(ADMoney.money);
        if (ADMoney.money >= 35 && h6==false)
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
            h6 = true;
        }
        else if (h6 == true)
        {
            panelAlreadyInCloset.SetActive(true);
            StartCoroutine(WaitSeconds());
        }
        else
        {
            panelOutOfMoney.SetActive(true);
            StartCoroutine(WaitSeconds());
        }


    }


    IEnumerator WaitSeconds()
    {
        yield return new WaitForSeconds(2);
        panelOutOfMoney.SetActive(false);
        panelAlreadyInCloset.SetActive(false);
    }

    /*public void ShowP1InCloset()
    {
       
    }*/
}
