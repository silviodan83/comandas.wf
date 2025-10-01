using Comandas.Wf.Modelos;
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
            if (!comandasDbContext.Mesas.Any())
            {
                comandasDbContext.Mesas.Add(new Modelos.Mesa
                {
                    NumeroMesa = 1,
                    SituacaoMesa = 0
                    
                });
                comandasDbContext.Mesas.Add(new Modelos.Mesa
                {
                    NumeroMesa = 2,
                    SituacaoMesa = 0
                });
                comandasDbContext.Mesas.Add(new Modelos.Mesa
                {
                    NumeroMesa = 3,
                    SituacaoMesa = 0,
                });
            }
            if (!comandasDbContext.CardapioItems.Any())
            {
                comandasDbContext.CardapioItems.Add(new CardapioItem
                {
                    Descricao = "Coca Cola Lata 350ml",
                    PossuiPreparo = false,
                    Preco = 5m,
                    Titulo = "Coca Cola Lata 350ml",
                });
                comandasDbContext.CardapioItems.Add(new CardapioItem
                {
                    Descricao = "Fanta Laranja Lata 350ml",
                    PossuiPreparo = false,
                    Preco = 5m,
                    Titulo = "Fanta Laranja Lata 350ml",
                });
                comandasDbContext.CardapioItems.Add(new CardapioItem
                {
                    Descricao = "Bland de 180g, pão de brioche, salada e bacon",
                    PossuiPreparo = true,
                    Preco = 25m,
                    Titulo = "X-Bacon"
                });
                comandasDbContext.CardapioItems.Add(new CardapioItem
                {
                    Descricao = "Bland de 180g, pão de brioche e salada",
                    PossuiPreparo = true,
                    Preco = 20m,
                    Titulo = "X-Salada"
                });
            }
            if (!comandasDbContext.Comandas.Any())
            {
                comandasDbContext.Comandas.Add(new Comanda
                {
                    NomeCliente = "Silvio Nespoli Dan",
                    NumeroMesa = 1,
                    SituacaoComanda = 0, // é isso mesmo?
                    //ComandaItens = , // não sei o que recebe
                });
                comandasDbContext.Comandas.Add(new Comanda
                {
                    NomeCliente = "Viviane Dan",
                    NumeroMesa = 2,
                    SituacaoComanda = 0, // é isso mesmo?
                    //ComandaItens = , // não sei o que recebe
                });
                comandasDbContext.Comandas.Add(new Comanda
                {
                    NomeCliente = "Felipe de Oliveia Dan",
                    NumeroMesa = 3,
                    SituacaoComanda = 0, // é isso mesmo?
                    //ComandaItens = , // não sei o que recebe
                });
            }
            if (!comandasDbContext.PedidoCozinhas.Any())
            {
                comandasDbContext.PedidoCozinhas.Add(new PedidoCozinha
                {
                    ComandaId = 1,
                    //Comanda = 1, // não sei o que recece
                    SituacaoId = 1 //  
                });
            }
            // Salva as alterações
            comandasDbContext.SaveChanges();
        }
    }
}
