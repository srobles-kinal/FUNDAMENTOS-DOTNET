using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace OrderWorkerManagement.Domain.Entities
{
    public class Aspirante
    {
        public string Apellidos {get; set;}       
        public string Direccion {get; set;}   
        public string Telefono {get; set;}   
        public string Email {get; set;}           
        public string ExamenId {get; set;}   
        public string CarreraId {get; set;}   
        public string JornadaId {get; set;}   
    }
}