using System;
using System.Collections.Generic;


public class backgroundRespository
{

    Dictionary<int, BackgroundEntity> all;

    BackgroundEntity[] temArray;

    public backgroundRespository()
    {
        all = new Dictionary<int, BackgroundEntity>();
        temArray = new BackgroundEntity[5];
    }

    public void Add(BackgroundEntity entity)
    {
        all.Add(entity.id, entity);
    }

    public void Remove(BackgroundEntity entity)
    {
        all.Remove(entity.id);
    }

    public int TakeAll(out BackgroundEntity[] array)
    {
        if (all.Count > temArray.Length)
        {
            temArray = new BackgroundEntity[all.Count * 2];
        }
        all.Values.CopyTo(temArray, 0);

        array = temArray;
        return all.Count;

    }

    public bool TryGet(int id, out BackgroundEntity entity)
    {
        return all.TryGetValue(id, out entity);
    }

    public void Foreach(Action<BackgroundEntity> action)
    {
        foreach (var item in all.Values)
        {
            action(item);
        }
    }
    public BackgroundEntity Find(Predicate<BackgroundEntity> predicate)
    {
        foreach (BackgroundEntity MapEle in all.Values)
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