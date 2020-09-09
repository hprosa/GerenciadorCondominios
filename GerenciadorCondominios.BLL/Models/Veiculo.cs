﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;
using System.Text;

namespace GerenciadorCondominios.BLL.Models
{
    public class Veiculo
    {
        public int VeiculoID { get; set; }
        [Required(ErrorMessage ="O campo {0} é obrigatório")]
        [StringLength(20, ErrorMessage ="Use apenas 20 caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(20, ErrorMessage = "Use apenas 20 caracteres")]
        public string  Marca { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(20, ErrorMessage = "Use apenas 20 caracteres")]
        public string Cor { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Placa { get; set; }
        public string UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

    }
}
