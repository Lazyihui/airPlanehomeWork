using System;
using UnityEngine;



public class GameContext {

    public GameEntity gameEntity;
    public ModuleInput moduleInput;

    // repo
    public MapRespository mapRespository;

    public backgroundRespository backgroundRespository;

    public PlayerRespository playerRespository;

    public RocketRespository rocketRespository;

    public MstRespository mstRespository;
    // inject
    public AssetsContext assetsContext;

    public GameContext() {
        // entity
        gameEntity = new GameEntity();
        // repo
        mapRespository = new MapRespository();
        backgroundRespository = new backgroundRespository();
        playerRespository = new PlayerRespository();
        rocketRespository = new RocketRespository();
        mstRespository = new MstRespository();
    }

    public void Inject(AssetsContext assetsContext, ModuleInput moduleInput) {
        this.assetsContext = assetsContext;
        this.moduleInput = moduleInput;
    }
}