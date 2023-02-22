﻿//Autor:Jose Roberto Taveras
//Email:roberto.taveras@hotmail.com
//Fecha:2/22/2023 8:16:32 AM
//Licencia:Frederic Schad (Todos los derechos Reservados)

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BusinessObjects.Interfaces;

namespace BusinessObjects.Mocks
{
    public class MockInvoiceDetails : IInvoiceDetails , IValidate  {
    
        public int Id {get; set;}
		public int InvoiceId {get; set;}
		public int productId {get; set;}
		public int Qty {get; set;}
		public decimal Price {get; set;}
		public decimal TotalItbis {get; set;}
		public decimal SubTotal {get; set;}
		public decimal Total {get; set;}
		public long TenantId {get; set;}
		public bool IsActivo {get; set;}
		public string Creado {get; set;}
		public DateTime FechaCreado {get; set;}
		public string Modificado {get; set;}
		public DateTime FechaModificado {get; set;}
		     
        public void ClearErrorsValidations()
        {
           
        }

        public void ShowErrors()
        {
           
        }

    } 
}
