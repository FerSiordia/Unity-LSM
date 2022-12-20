using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagazineController : MonoBehaviour
{
    //public GameObject revista;
    public GameObject panelMenu;
    public GameObject panelPlayeras;
    public GameObject panelPants;
    public GameObject panelCabello;
    public GameObject jugador;

    // Start is called before the first frame update
    void Start()
    {
        //revista.SetActive(false);
        panelCabello.SetActive(false);
        panelMenu.SetActive(false);
        panelPants.SetActive(false);
        panelPlayeras.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Magazine")) {
            panelMenu.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
