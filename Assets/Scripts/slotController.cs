using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class slotController : MonoBehaviour{

    private gameController _gameController; 
    private float tempTime, fillAmount;
    private double goldProduced;

    public slotGame _slotGame;

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

        _gameController = FindObjectOfType(typeof(gameController)) as gameController;

        baseHud.transform.position = hudPosition.position;

        _slotGame.initializedSlotGame();
    }

    // Update is called once per frame
    void Update(){

        //verificar estado game e nao deixar gera coin quando tiver modo UpgradeMode 
        if(_gameController.currentState != GameState.GAMEPLAY){
            return;
        }

        //verificando producao ouro
        if(goldProduced == 0){
            production();
        }else if(goldProduced > 0 && _slotGame.isAutoProduction == true){
            production();
        }
    }

    void production(){

        tempTime += Time.deltaTime;

        //fazendo porcetangem bar progreso
        fillAmount = tempTime / _slotGame.timeProduct;

        loadProduction.fillAmount = fillAmount;

        if(tempTime >= _slotGame.timeProduct){

            tempTime = 0;
            goldProduced += _slotGame.production;

            //txtProduction.text = goldProduced.ToString();
            txtProduction.text = _gameController.convertMonetary(goldProduced);
        }

        if(goldProduced > 0){
            iconCoin.SetActive(true);
        }else{
            iconCoin.SetActive(false);
        }
    }

    public void collectGold() {

        //verificar estado game e nao deixar gera coin quando tiver modo UpgradeMode 
        if(_gameController.currentState != GameState.GAMEPLAY){
            return;
        }

        _gameController.GetCoin(goldProduced);
        goldProduced = 0;
        //txtProduction.text = goldProduced.ToString();
        txtProduction.text = _gameController.convertMonetary(goldProduced);
    }

    void OnMouseEnter(){
        //Debug.Log("coletar ouro");
        collectGold();
    }

    void OnMouseDown(){
        //Debug.Log("Clicou");
        collectGold();
    }

    public void UpgradeMode(){

        if(_slotGame.isBuy == true){

            switch (_gameController.isUpgradeMode){
                
                case true:
                    hudActive.SetActive(false);
                    hudUpgrade.SetActive(true);
                break;

                case false:
                    hudActive.SetActive(true);
                    hudUpgrade.SetActive(false);
                break;
            }

        }
    }

    public void UpgradeSlot(){
        Debug.Log("upgrade slot");
    }

}