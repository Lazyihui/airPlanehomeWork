using System;
using UnityEngine;


public static class Game_Business {
    public static void Enter(GameContext ctx) {

        MapEntity map = MapDomain.Spawn(ctx);

        BackgroundDomain.Spawn(ctx, new Vector3(0, -5, 0));
        BackgroundDomain.Spawn(ctx, new Vector3(0, -5, -159));

        PlayerDomain.Spawn(ctx);

        MstDomain.Spawn(ctx);

    }



    public static void Tick(GameContext ctx, float dt) {
        PreTick(ctx, dt);
        ref float restFixTime = ref ctx.gameEntity.restFixTime;

        restFixTime += dt;
        const float FIX_INTERVAL = 0.020f;

        if (restFixTime <= FIX_INTERVAL) {

            LogicTick(ctx, restFixTime);
            restFixTime = 0;
        } else {
            while (restFixTime >= FIX_INTERVAL) {
                restFixTime -= FIX_INTERVAL;
                LogicTick(ctx, FIX_INTERVAL);
            }
        }

        LateTick(ctx, dt);

    }


    static void PreTick(GameContext ctx, float dt) {
        ctx.moduleInput.ProcessMove();
    }


    static void LogicTick(GameContext ctx, float dt) {
        int lenBg = ctx.backgroundRespository.TakeAll(out BackgroundEntity[] bgs);
        for (int i = 0; i < lenBg; i++) {
            BackgroundEntity bg = bgs[i];

            BackgroundDomain.Move(bg, dt);
        }

        int lenPlayer = ctx.playerRespository.TakeAll(out PlayerEntity[] players);

        for (int i = 0; i < lenPlayer; i++) {
            PlayerEntity player = players[i];

            PlayerDomain.Move(ctx, player, ctx.moduleInput.moveAxis, dt);
            PlayerDomain.PlayerToSpawnRocket(ctx, player, dt);
        }

        int lenRocket = ctx.rocketRespository.TakeAll(out RocketEntity[] rockets);  
        for (int i = 0; i < lenRocket; i++) {
            RocketEntity rocket = rockets[i];

            RocketDomain.Move(ctx, rocket, dt);
        }

    }


    static void LateTick(GameContext ctx, float dt) {

    }
}