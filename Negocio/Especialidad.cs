using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Net.Http.Json;
using Datos;
using System.Net.Http;

namespace Negocio
{
    public class Especialidad
    {
        public async static Task<IEnumerable<Entidades.Especialidad>> GetAll()
        {
            var response = await Conexion.Instancia.Cliente.GetStringAsync("https://localhost:7092/api/Especialidad");
            var data = JsonConvert.DeserializeObject<List<Entidades.Especialidad>>(response);
            return data;
        }
        public async static Task<IEnumerable<Entidades.Especialidad>> GetByDesc(string desc) 
        {
            var response = await Conexion.Instancia.Cliente.GetStringAsync("https://localhost:7092/api/especialidad/GetByDesc/"+desc);
            var data = JsonConvert.DeserializeObject<List<Entidades.Especialidad>>(response);
            return data;
        }
        
        public async static Task<Boolean> Add(Entidades.Especialidad e)
        {
            if (e.Descripcion == "")
                throw (new Exception("Falta descripción"));
            var response = await Conexion.Instancia.Cliente.PostAsJsonAsync("https://localhost:7092/api/Especialidad", e);
            return response.IsSuccessStatusCode;
        }
        public async static Task<Boolean> Delete(Entidades.Especialidad e)
        {
            var response = await Conexion.Instancia.Cliente.DeleteAsync("https://localhost:7092/api/Especialidad/" + e.ID);
            return response.IsSuccessStatusCode;
        }
        public async static Task<Boolean> Update(Entidades.Especialidad e)
        {
            if (e.Descripcion == "")
                throw (new Exception("Falta descripción"));
            var response = await Conexion.Instancia.Cliente.PutAsJsonAsync("https://localhost:7092/api/Especialidad/" + e.ID, e);
            return response.IsSuccessStatusCode;
        }

    }
}
