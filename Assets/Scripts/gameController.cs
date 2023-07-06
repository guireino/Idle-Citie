using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public enum GameState{
    GAMEPLAY, UPGRADE
}

public class gameController : MonoBehaviour{

    public GameState currentState;

    public List<slotController> slots;
    public double gold, goldAccrued;
    public TMP_Text goldTxt, diamondTxt;
    public bool isUpgradeMode;

    // Start is called before the first frame update
    void Start(){

        goldTxt.text = convertMonetary(gold);
        
        //add terreno em seu lugar
        foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Ground")){
            slots.Add(obj.GetComponentInChildren<slotController>());
        }
    }

    // Update is called once per frame
    void Update(){
        
    }

    public void GetCoin(double qtd){

        gold += qtd;

        if (qtd > 0){
            goldAccrued += qtd;
        }

        //goldTxt.text = gold.toString();
        goldTxt.text = convertMonetary(gold);
    }

    public string convertMonetary(double value){

        string coinValue = "";

        coinValue = value.ToString();
        return coinValue;
    }

    public void ChangeState(GameState newState){
        currentState = newState;
    }

    public void UpgradeMode(){

        isUpgradeMode = !isUpgradeMode;

        // mudando estado game
        switch (isUpgradeMode){
            
            case true:
                ChangeState(GameState.UPGRADE);
            break;

            case false:
                ChangeState(GameState.GAMEPLAY);
            break;
        }

        //foresch para ler todos slots
        foreach (slotController s in slots){
            s.UpgradeMode();
        }
    }
}