using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace OrderWorkerManagement.Domain.Entities
{
    public class Applicant : EntityData
    {
        public string ShiftId {get;set;}      
        public string ExamId {get; set;}   
        public string CarrerId {get; set;}   
      
        public Applicant() : base()
        {
            
        }

          public Applicant(string lastName, string firstName, string address, string email, string shifId, string examId, string carreerId) 
                : base(lastName, firstName, address, email)
        {
            this.ShiftId = shifId;
            this.ExamId = examId;
            this.CarrerId = carreerId;
        }
        public override string showId()
        {
             return $"El número de expediente es {ShiftId}";
        }
    }
}