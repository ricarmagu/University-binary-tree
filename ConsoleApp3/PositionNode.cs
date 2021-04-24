using System;
using System.Collections.Generic;
using System.Text;

namespace Arboles_Binarios
{
    class TreeNode<T>
    {
        private T dato;
        private TreeNode<T> izq, der;

        public TreeNode(T d)
        {
            dato = d;
            izq = der = null;
        }

        public override string ToString()
        {
            return " " + dato;
        }

        public T getDato()
        {
            return dato;
        }

        public void setDato(T dato)
        {
            this.dato = dato;
        }

        public TreeNode<T> getIzq()
        {
            return izq;
        }

        public void setIzq(TreeNode<T> izq)
        {
            this.izq = izq;
        }

        public TreeNode<T> getDer()
        {
            return der;
        }

        public void setDer(TreeNode<T> der)
        {
            this.der = der;
        }




    }
}