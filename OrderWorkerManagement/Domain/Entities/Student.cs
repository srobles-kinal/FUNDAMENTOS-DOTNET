using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderWorkerManagement.Domain.Entities
{
    public class Student : EntityData
    {
        public string StudentId {get;set;}

        public override string showId()
        {
            return $"El número de expediente es {StudentId}";
        }
    }
}