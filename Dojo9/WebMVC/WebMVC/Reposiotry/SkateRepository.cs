using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMVC.Models;

namespace WebMVC.Reposiotry
{
    public class SkateRepository
    {
        private static List<Skate> skates = new List<Skate>();


        public void Create(Skate model)
        {
            skates.Add(model);
        }

        public List<Skate> Read()
        {
            return skates;
        }
        public Skate Read(int id)
        {
            return skates.Find(s => s.Id == id);
        }

       
        public void Delete(int id)
        {
            Skate model = Read(id);
            if (model != null)
            {
                skates.Remove(model);
            }
        }

        public void Editar(Skate model)
        {
            int index = skates.FindIndex(s => s.Id == model.Id);
            skates[index] = model;
        }
    }
}