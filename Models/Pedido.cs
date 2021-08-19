using System;
using System.Collections.Generic;

namespace ATIVIDADE_1
{
    public class Pedido
    {
        private List<ItemPedido> listaItens = new List<ItemPedido> ();


      
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

       

        public List<ItemPedido> ListaPedido()
        {
            return listaItens;
        }

        
    }
}
        
