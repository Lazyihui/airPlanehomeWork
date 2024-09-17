using System;
using UnityEngine;


public class MainContext {

    
    public GameContext gameContext;

    public AssetsContext assetsContext;

    public MainContext() {
        gameContext = new GameContext();
        assetsContext = new AssetsContext();
    }


    public void Inject() { }

}