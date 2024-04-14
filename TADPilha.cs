using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProjetoPilha
{
    internal class TADPilha
    {
        private class Nodulo
        {
            public int Codigo { get; set; }
            public string? Descricao { get; set; }
            public int Capacidade { get; set; }
            public Nodulo Next { get; set; }

            public Nodulo(int codigo, string descricao, int capacidade)
            {
                Codigo = codigo;
                Descricao = descricao;
                Capacidade = capacidade;
                Next = null;
            }
        }

        private Nodulo topo;

        public TADPilha()
        {
            topo = null;
        }
        public int? Pop()
        {
            if(topo == null)
            {
                Console.WriteLine("A pilha está vazia.");
                return null;
            }
            int codigo = topo.Codigo;
            topo = topo.Next;
            return codigo;
        }
        public void Push(int k)
        {            
            try
            {
                Console.WriteLine($"Digite a descrição do elemento de código {k}:");
                string descricao = Console.ReadLine();
                Console.WriteLine($"Digite a capacidade do elemento de código {k}");
                int capacidade = int.Parse(Console.ReadLine());
                Nodulo novoNodulo = new Nodulo(k, descricao, capacidade);
                novoNodulo.Next = topo;
                topo = novoNodulo;
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            } 
        }
        public void ImprimirPilha()
        {
            if (topo == null)
            {
                Console.WriteLine("A pilha está vazia.");
                return;
            }

            Console.WriteLine("Conteúdo da pilha:");

            Nodulo atual = topo;
            while(atual != null)
            {
                Console.WriteLine($"Código: {atual.Codigo}, Descrição: {atual.Descricao}, Capacidade: {atual.Capacidade}.");
                atual = atual.Next;
            }
        }
    }
}
