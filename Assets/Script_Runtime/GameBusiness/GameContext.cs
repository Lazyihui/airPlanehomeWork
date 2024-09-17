using System;
using UnityEngine;



public class GameContext {

    public GameEntity gameEntity;

    // repo
    public MapRespository mapRespository;


    public GameContext() {
        // entity
        gameEntity = new GameEntity();

        // repo
        mapRespository = new MapRespository();
    }
}