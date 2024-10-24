using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArvoresBasicas
{
    public class Node<T> // Esse porra aqui é um nó
    {
        public T? Data { get; set; } // Vo armazena um dado
        public Node<T>? Parent { get; set; } // É recursivo (Um dentro do outro safada) referencia do nó anterior
        public List<Node<T>>? Children { get; set; } = [];

        public int GetHeight() {
            int height = 1;
            Node<T> current = this;
            while(current.Parent != null) {
                height ++;
                current = current.Parent;
            }
            return height;

        }
    }
}
