using System;
using UnityEngine;



public class GameContext {

    public GameEntity gameEntity;

    // repo
    public MapRespository mapRespository;

    public backgroundRespository backgroundRespository;
    // inject
    public AssetsContext assetsContext;

    public GameContext() {
        // entity
        gameEntity = new GameEntity();

        // repo
        mapRespository = new MapRespository();
        backgroundRespository = new backgroundRespository();
    }

    public void Inject(AssetsContext assetsContext) {
        this.assetsContext = assetsContext;
    }
}