using AppWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppWeb.Repository
{
    public class CarrosRepository
    {
        private static List<Carros> listaCarros = new List<Carros>();

        public void Create(Carros model)
        {
            listaCarros.Add(model);
        }

        public List<Carros> Read()
        {
            return listaCarros;
        }

        public void Update(Carros model)
        {
            Carros novoCarro = listaCarros.Find(carro => carro.Id == model.Id);
            if(novoCarro != null)
            {
                novoCarro = model;
            }
        }

        public void Delete(int id)
        {
            Carros model = listaCarros.Find(carro => carro.Id == id);
            if (model != null)
            {
                listaCarros.Remove(model);
            }
        }
    }
}