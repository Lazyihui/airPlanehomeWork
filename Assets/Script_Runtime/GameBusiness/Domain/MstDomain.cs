using System;
using UnityEngine;


public static class MstDomain {
    public static MstEntity Spawn(GameContext ctx) {
        MstEntity entity = GameFactory.Mst_Create(ctx);
        ctx.mstRespository.Add(entity);
        return entity;
    }
    
}