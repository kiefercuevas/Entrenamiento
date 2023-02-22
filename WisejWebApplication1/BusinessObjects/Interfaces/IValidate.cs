﻿//Author: Jose Roberto Taveras
//Email:roberto.taveras@hotmail.com
//Description: Poco de entidad IPresenter
//Fecha:2/21/2023 2:50:38 PM
//Licencia:Frederic Schad (Todos los derechos Reservados)

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BusinessObjects.Interfaces
{
    public interface IValidate
    {
        void ShowErrors();
        void ClearErrorsValidations();
    }
}
