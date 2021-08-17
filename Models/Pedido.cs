using System;
using System.Collections.Generic;

namespace ATIVIDADE_1
{
    public class NewBaseType
    {
        internal void AddPedido() => throw new NotImplementedException();
    }

    public class Pedido : NewBaseType
    {
        private List<ItemPedido> listaItens;


        public Pedido()
        {
            listaItens = new List<ItemPedido>();
        }

        public void IncluirItem(ItemPedido i)
        {
            listaItens.Add(i);
        }

        public double FinalizarPedido()
        {
            double total = 0;
            for(int i = 0; i < listaItens.Count; i++)
            {
                total += (listaItens[i].valor_unitario * listaItens[i].quantidade);
            }

            return total;
        }

        internal List<ItemPedido> ListarPedidos()
        {
            throw new NotImplementedException();
        }

        public double Total()
        {
            double total = 0;
            for(int i = 0; i < listaItens.Count; i++)
            {
                total += (listaItens[i].valor_unitario * listaItens[i].quantidade);
            }

            return total;
        }

        
    }
}