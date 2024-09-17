using System;
using System.Collections.Generic;


public class MapEleRespository
{

    Dictionary<int, MapEleEntity> all;

    MapEleEntity[] temArray;

    public MapEleRespository()
    {
        all = new Dictionary<int, MapEleEntity>();
        temArray = new MapEleEntity[5];
    }

    public void Add(MapEleEntity entity)
    {
        all.Add(entity.id, entity);
    }

    public void Remove(MapEleEntity entity)
    {
        all.Remove(entity.id);
    }

    public int TakeAll(out MapEleEntity[] array)
    {
        if (all.Count > temArray.Length)
        {
            temArray = new MapEleEntity[all.Count * 2];
        }
        all.Values.CopyTo(temArray, 0);

        array = temArray;
        return all.Count;

    }

    public bool TryGet(int id, out MapEleEntity entity)
    {
        return all.TryGetValue(id, out entity);
    }

    public void Foreach(Action<MapEleEntity> action)
    {
        foreach (var item in all.Values)
        {
            action(item);
        }
    }
    public MapEleEntity Find(Predicate<MapEleEntity> predicate)
    {
        foreach (MapEleEntity MapEle in all.Values)
        {
            bool isMatch = predicate(MapEle);

            if (isMatch)
            {
                return MapEle;
            }
        }
        return null;
    }

}