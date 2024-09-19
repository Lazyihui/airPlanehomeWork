using System;
using System.Collections.Generic;


public class RocketRespository {

    Dictionary<int, RocketEntity> all;

    RocketEntity[] temArray;

    public RocketRespository() {
        all = new Dictionary<int, RocketEntity>();
        temArray = new RocketEntity[5];
    }

    public void Add(RocketEntity entity) {
        all.Add(entity.id, entity);
    }

    public void Remove(RocketEntity entity) {
        all.Remove(entity.id);
    }

    public int TakeAll(out RocketEntity[] array) {
        if (all.Count > temArray.Length) {
            temArray = new RocketEntity[all.Count * 2];
        }
        all.Values.CopyTo(temArray, 0);

        array = temArray;
        return all.Count;

    }

    public bool TryGet(int id, out RocketEntity entity) {
        return all.TryGetValue(id, out entity);
    }

    public void Foreach(Action<RocketEntity> action) {
        foreach (var item in all.Values) {
            action(item);
        }
    }
    public RocketEntity Find(Predicate<RocketEntity> predicate) {
        foreach (RocketEntity Rocket in all.Values) {
            bool isMatch = predicate(Rocket);

            if (isMatch) {
                return Rocket;
            }
        }
        return null;
    }

}