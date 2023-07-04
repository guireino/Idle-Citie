using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//CreateAssetMenu criar opcao no unity 3d quando for create vai aparece a opcao,
//collection e Card para criar objeto com configuracao scripts

[CreateAssetMenu(fileName = "New Card", menuName = "Collection/Card")]

public class card : ScriptableObject{

    public enum typeCard{common, rare, epica, legendary}

    [Header("Info Card")]
    public string nameCard;
    public Sprite spriteCard;
    public Sprite spriteCardDisable;
    public typeCard rarity;
    public double production;
    public float timeProduction;

    [Header("Data Staring")]
    public float timeReducerProduct = 1;
    public int multiplexed = 1;
    public int cardLevel = 1;
    public int cardCollected = 0;
    public bool isReleasedStaring;
    public bool isReleased;

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        
    }

    public void resetCard(){
        isReleased = isReleasedStaring;
        multiplexed = 1;
        timeReducerProduct = 1;
        cardLevel = 1;
        cardCollected = 0;
    }

}