using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//CreateAssetMenu criar opcao no unity 3d quando for create vai aparece a opcao,
//collection e Card para criar objeto com configuracao scripts

[CreateAssetMenu(fileName = "New slot", menuName = "Slot Game/Slot")]

public class slotGame : ScriptableObject{

    private bool initialized;

    public card card;
    public bool isBuy;
    public bool isMaximized;
    public bool isAutoProduction;

    public double costSlot, costUpgrade, production;
    public float timeProduct, timeReducerProduct = 1;
    public int slotLevel, evolution, totalEvolution, multiplexed = 1;

    public void initializedSlotGame(){

        int mult = 1;

        if(totalEvolution > 0){
            mult = totalEvolution;
        }

        //caculando valores slot
        production = card.production * card.multiplexed * mult * multiplexed;

        costUpgrade = production * multiplexed * 1.5f;

        timeProduct = card.timeProduction / card.timeReducerProduct / timeReducerProduct;
    }
}