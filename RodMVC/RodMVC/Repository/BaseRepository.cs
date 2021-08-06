using RodMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RodMVC.Repository
{
    public abstract class BaseRepository <T> where T : BaseModel
    {
         public static List<T> list = new List<T>();
        public virtual void Create(T model)
        {
            list.Add(model);
        }

        public virtual List<T> Read()
        {
            return list;
        }
        public T  Read(int id)
        {
            return list.Find(m => m.Id == id);
        }
        public void Update(T model)
        {
            int index = list.FindIndex(m => m.Id == model.Id);
            if (index != -1)
            {
                list[index] = model;
            }
        }
        public void Delete(int id)
        {
            T model = Read(id);
            if (model != null)
                list.Remove(model);
        }
    }
}