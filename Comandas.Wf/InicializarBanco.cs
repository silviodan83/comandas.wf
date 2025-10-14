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
            comandasDbContext.Database.EnsureCreated();
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
            var cardapio1 = new CardapioItem
            {
                Descricao = "Coca Cola Lata 350ml",
                PossuiPreparo = false,
                Preco = 5m,
                Titulo = "Coca Cola Lata 350ml",
            };
            var cardapio2 = new CardapioItem
            {
                Descricao = "Fanta Laranja Lata 350ml",
                PossuiPreparo = false,
                Preco = 5m,
                Titulo = "Fanta Laranja Lata 350ml",
            };
            var cardapio3 = new CardapioItem
            {
                Descricao = "Bland de 180g, pão de brioche, salada e bacon",
                PossuiPreparo = true,
                Preco = 25m,
                Titulo = "X-Bacon"
            };
            var cardapio4 = new CardapioItem
            {
                Descricao = "Bland de 180g, pão de brioche e salada",
                PossuiPreparo = true,
                Preco = 20m,
                Titulo = "X-Salada"
            };
            if (!comandasDbContext.CardapioItems.Any())
            {
                comandasDbContext.CardapioItems.Add(cardapio1);
                comandasDbContext.CardapioItems.Add(cardapio2);
                comandasDbContext.CardapioItems.Add(cardapio3);
                comandasDbContext.CardapioItems.Add(cardapio4);
            }
            if (!comandasDbContext.Comandas.Any())
            {
                comandasDbContext.Comandas.Add(new Comanda
                {
                    NomeCliente = "Silvio Nespoli Dan",
                    NumeroMesa = 1,
                    SituacaoComanda = 1,
                    ComandaItens = new List<ComandaItens>() 
                    { 
                    new ComandaItens
                    {
                       CardapioItem = cardapio1
                    },
                    new ComandaItens 
                    {
                       CardapioItem = cardapio2
                    }
                    }
                });
                comandasDbContext.Comandas.Add(new Comanda
                {
                    NomeCliente = "Viviane Dan",
                    NumeroMesa = 2,
                    SituacaoComanda = 1,
                    ComandaItens = new List<ComandaItens>()
                    {
                    new ComandaItens
                    {
                       CardapioItem = cardapio3
                    },
                    new ComandaItens
                    {
                       CardapioItem = cardapio4
                    }
                    }
                });
                comandasDbContext.Comandas.Add(new Comanda
                {
                    NomeCliente = "Felipe de Oliveia Dan",
                    NumeroMesa = 3,
                    SituacaoComanda = 1,
                    ComandaItens = new List<ComandaItens>()
                    {
                    new ComandaItens
                    {
                       CardapioItem = cardapio1
                    }
                    }
                });
            }
            if (!comandasDbContext.PedidoCozinhas.Any())
            {
                //comandasDbContext.PedidoCozinhas.Add(new PedidoCozinha
                //{
                //    ComandaId = 2,
                //    SituacaoId = 1,
                    //itens = new List<PedidoCozinhaItem>
                    //{ 
                    //    new PedidoCozinhaItem
                    //    {
                    //        ComandaItemId = 3,
                    //    }
                    //}

               // });
            }
            // Salva as alterações
            comandasDbContext.SaveChanges();
        }
    }
}
