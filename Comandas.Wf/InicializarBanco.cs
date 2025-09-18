using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandas.Wf
{
    public static class InicializarBanco
    {
        public static void Inicializar(ComandasDbContext comandasDbContext)
        {
            // Se não tem nenhum usuário no banco
            if (!comandasDbContext.Usuarios.Any())
            {
                // Adiciona um novo usuário
                comandasDbContext.Usuarios.Add(new Modelos.Usuario
                {
                    EmailUsuario = "admin@admin.com",
                    NomeUsuario = "admin",
                    SenhaUsuario = "123"
                });
            }
            // Salva as alterações
            comandasDbContext.SaveChanges();
        }
    }
}
