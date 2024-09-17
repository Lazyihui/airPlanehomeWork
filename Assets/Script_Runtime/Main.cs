using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

    MainContext ctx;
    bool isTearDown; // 是否已销毁

    void Awake() {
        // ==== Phase: Instantiate ====
        ctx = new MainContext();

        // ==== Phase: Inject ====
        ctx.Inject();
        // ==== Phase: Init ====
        ModuleAssets.Load(ctx.assetsContext);

        // ==== Phase: Enter Game ====
        Game_Business.Enter(ctx.gameContext);
    }


    void Update() {

    }


    // 当 安卓/iOS 应用程序退出时调用
    void OnApplicationQuit() {
        TearDown();
    }

    void OnDestroy() {
        TearDown();
    }

    // 非官方生命周期
    void TearDown() {

        if (isTearDown) {
            return;
        }
        isTearDown = true;

        ModuleAssets.Unload(ctx.assetsContext);

    }
}
