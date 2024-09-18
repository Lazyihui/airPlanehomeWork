using System;
using UnityEngine;



public class GameContext {

    public GameEntity gameEntity;
    public ModuleInput moduleInput;

    // repo
    public MapRespository mapRespository;

    public backgroundRespository backgroundRespository;

    public PlayerRespository playerRespository;

    // inject
    public AssetsContext assetsContext;

    public GameContext() {
        // entity
        gameEntity = new GameEntity();
        // repo
        mapRespository = new MapRespository();
        backgroundRespository = new backgroundRespository();
        playerRespository = new PlayerRespository();
    }

    public void Inject(AssetsContext assetsContext, ModuleInput moduleInput) {
        this.assetsContext = assetsContext;
        this.moduleInput = moduleInput;
    }
}