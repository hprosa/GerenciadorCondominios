﻿using GerenciadorCondominios.BLL.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorCondominios.DAL.Interface
{
    public interface IUsuarioRepositorio : IRepositorioGenerico<Usuario>
    {
        int verificarSeExisteRegistro();
        Task LogarUsuario(Usuario usuario, bool lembrar);
        Task<IdentityResult> CriarUsuario(Usuario usuario, string senha);
        Task IncluirUsuarioEmFuncao(Usuario usuario, string funcao);
    }
}
