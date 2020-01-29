﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRsoft.Store.UI.Models
{
    public class SignInVM
    {
        [Required(ErrorMessage = "E-mail deve ser informado.")]
        [EmailAddress(ErrorMessage = "E-mail inválido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha deve ser informada.")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        
        public bool Lembrar { get; set; }
    }
}
