﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace _03_ValidacaoCostumizada
{
    class Usuario
    {
        [Required(ErrorMessage = "O campo 'Nome' é de preenchimento obrigatório.")]
        public string Nome { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required, StringLength(10, MinimumLength = 6)]
        [MyValidation(ErrorMessage ="O campo senha deve possuir 10 caracteres")]
        public string Senha { get; set; }

    }
}
