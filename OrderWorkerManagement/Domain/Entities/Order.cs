using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security;
using System.Threading.Tasks;

namespace OrderWorkerManagement.Domain.Entities
{
    public class Order
    {

        #region "Propiedades"
        private readonly string _OrderId = Guid.NewGuid().ToString();
        private string _entityType;
        public string OperationType {get; set;}
        public string Status {get; set;}
        public Aspirante _Data {get; set;}

        #endregion

        #region "getters y setters forma larga"
        public string OrderId
        {
            get
            {
                return this._OrderId;
            }
         
        }

        public string EntityType{

            get{
                return _entityType;
            }
            set{
              _entityType = value.ToUpper();  
            }
        }

        #endregion

        public void Processed()
        {
            this.Status = "Processed";
        }

        public void Failed()
        {
            this.Status = "Failed";
        }

    }
}