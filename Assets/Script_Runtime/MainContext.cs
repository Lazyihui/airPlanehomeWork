using System;
using UnityEngine;


public class MainContext {


    public GameContext gameContext;

    public AssetsContext assetsContext;
    public ModuleInput moduleInput;

    public MainContext() {
        gameContext = new GameContext();
        assetsContext = new AssetsContext();
        moduleInput = new ModuleInput();
    }


    public void Inject() {
        gameContext.Inject(assetsContext,moduleInput);
    }

}