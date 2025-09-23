using System;
using System.Text.Json;
using Veterinaria.Models;
namespace Veterinaria.Servicios
{
	public interface IRepositorioGato
	{
		List<Gatos> ObtenerGatos();
	}


	public class RepositorioGato: IRepositorioGato
	{
		public RepositorioGato()
		{
		}

        private readonly string _filePath = "Data/Gatos.json";

        public List<Gatos> ObtenerGatos()
        {
            if (!File.Exists(_filePath)) return new List<Gatos>();

            var json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<Gatos>>(json) ?? new List<Gatos>();
        }
    }
}

