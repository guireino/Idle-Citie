using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//CreateAssetMenu criar opcao no unity 3d quando for create vai aparece a opcao,
//collection e Card para criar objeto com configuracao scripts

[CreateAssetMenu(fileName = "New slot", menuName = "Slot Game/Slot")]

public class slotGame : ScriptableObject{

    public card card;
    public bool isBuy;
    public bool isMaximized;
    public bool isAutoProduction;

    public double costSlot;
    public int slotLevel;

}