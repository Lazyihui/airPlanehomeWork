using System;
using UnityEngine;



public class GameContext {

    public GameEntity gameEntity;

    // repo
    public MapRespository mapRespository;
    // inject
    public AssetsContext assetsContext;

    public GameContext() {
        // entity
        gameEntity = new GameEntity();

        // repo
        mapRespository = new MapRespository();
    }

    public void Inject(AssetsContext assetsContext) {
        this.assetsContext = assetsContext;
    }
}