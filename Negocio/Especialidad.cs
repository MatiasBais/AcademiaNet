using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Net.Http.Json;

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
            var response = await Conexion.Instancia.Cliente.GetStringAsync("https://localhost:7092/api/GetByDesc/" + desc);
            var data = JsonConvert.DeserializeObject<List<Entidades.Especialidad>>(response);
            return data;
        }
        public async static Task<Boolean> Add(Entidades.Especialidad e)
        {
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
            var response = await Conexion.Instancia.Cliente.PutAsJsonAsync("https://localhost:7092/api/Especialidad/" + e.ID, e);
            return response.IsSuccessStatusCode;
        }


        public List<Entidades.Especialidad> getEspecialidades()
        {
            Datos.Especialidad esp = new Datos.Especialidad();
            return esp.getEspecialidades();
        }

        public List<Entidades.Especialidad> getEspecialidades(string desc)
        {
            Datos.Especialidad esp = new Datos.Especialidad();
            return esp.getEspecialidades(desc);
        }

        public void addEspecialidad(Entidades.Especialidad especialidad)
        {
            if (especialidad.Descripcion == "")
                throw (new Exception("Falta descripción"));
            Datos.Especialidad esp = new Datos.Especialidad();
            esp.addEspecialidad(especialidad);
        }
        public void updateEspecialidad(Entidades.Especialidad especialidad)
        {
            if (especialidad.Descripcion == "")
                throw (new Exception("Falta descripción"));
            Datos.Especialidad esp = new Datos.Especialidad();
            esp.updateEspecialidad(especialidad);
        }
        public void deleteEspecialidad(Entidades.Especialidad especialidad)
        {
            Datos.Especialidad esp = new Datos.Especialidad();
            esp.deleteEspecialidad(especialidad);
        }
    }
}
