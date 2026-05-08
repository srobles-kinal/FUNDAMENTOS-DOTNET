using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security;
using System.Threading.Tasks;
using OrderWorkerManagement.Domain.Enums;

namespace OrderWorkerManagement.Domain.Entities
{
    public class Order
    {

        #region "Propiedades"
        private readonly string _OrderId = Guid.NewGuid().ToString();
        private EntityType _EntityType;
        private OperationType _OperationType;
        public OrderStatus Status {get; set;}
        public Applicant Aspirante {get; set;}

        #endregion

        #region "getters y setters forma larga"
        public string OrderId
        {
            get
            {
                return this._OrderId;
            }
         
        }

        public EntityType EntityType{

            get{
                return _EntityType;
            }
            set{
              _EntityType = value;  
            }
        }

        public OperationType OperationType
        {
            get
            {
                return _OperationType;
            }
            set
            {
                _OperationType = value;
            }
        }

        #endregion

        public void MarkAsProcessed ()
        {
            this.Status = OrderStatus.PROCESSED;
        }

        public void MarkAsFailed()
        {
            this.Status = OrderStatus.FAILED;
        }

    }
}