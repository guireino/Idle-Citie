using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class slotController : MonoBehaviour{

    public GameObject baseHud;
    public Transform hudPosition;

    [Header("Hud Slot Active")]
    public GameObject hudActive;
    public GameObject hudBuy;
    public GameObject hudActiveUpgrade;
    public GameObject iconCoin;
    public Image loadProduction;
    public TMP_Text txtProduction;

    [Header("Hud Slot Buy")]
    public GameObject hubBuy;
    public Image iconCoinBuy;
    public TMP_Text txtCoinPrice;

    [Header("Hud Slot Upgrade")]
    public GameObject hudUpgrade;
    public Image hudUpgradeImg;
    public Image barProgressImage;
    public TMP_Text txtEvolutionTotal;
    public TMP_Text txtCostEvolution;
    public TMP_Text txtSlotLevel;

    // Start is called before the first frame update
    void Start(){
        baseHud.transform.position = hudPosition.position;
    }

    // Update is called once per frame
    void Update(){
        
    }
}