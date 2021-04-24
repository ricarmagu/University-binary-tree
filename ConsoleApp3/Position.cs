using System;

namespace Arboles_Binarios
{
    class BinaryTree<T>
    {
        public TreeNode<T> raiz;
        int cant;
        int altura;

        public BinaryTree()
        {
            raiz = null;
        }

        public TreeNode<T> Raiz()
        {
            return raiz;
        }

        public void addPrioridadIzquierda(TreeNode<T> nodo, T dato)
        {
            if (nodo == null)
            {
                this.raiz = new TreeNode<T>(dato);
                return;
            }
            if (nivelArbol(nodo.getIzq(), 0) == nivelArbol(nodo.getDer(), 0))
            {

                if (!isEmpty(nodo.getIzq()))
                {
                    agregarNodoIzq(nodo, dato);
                    return;
                }
                else
                {
                    if (contarHojas(nodo.getIzq()) > contarHojas(nodo.getDer()))
                    {
                        addPrioridadIzquierda(nodo.getDer(), dato);
                    }
                    else
                    {
                        addPrioridadIzquierda(nodo.getIzq(), dato);
                    }
                }

            }
            else if (nivelArbol(nodo.getIzq(), 0) > nivelArbol(nodo.getDer(), 0))
            {
                if (!isEmpty(nodo.getDer()))
                {
                    agregarNodoDer(nodo, dato);
                }
                else
                {
                    addPrioridadIzquierda(nodo.getDer(), dato);
                }
            }
        }

        ////Añadir nodo al lado Izquierdo//
        private void agregarNodoIzq(TreeNode<T> nodo, T dato)
        {

            TreeNode<T> aux = new TreeNode<T>(dato);
            nodo.setIzq(aux);
        }

        ///Añadir nodo al lado Derecho/
        private void agregarNodoDer(TreeNode<T> nodo, T dato)
        {

            TreeNode<T> aux = new TreeNode<T>(dato);
            nodo.setDer(aux);
        }

        ///comprobar si el nodo esta vacio/
        private bool isEmpty(TreeNode<T> nodo)
        {

            if (nodo == null)
            {
                return false;
            }
            return true;
        }

        ///Nivel del arbol iniciando en 0/
        public int nivelArbol(TreeNode<T> raiz, int inicio)
        {

            if (raiz == null)
            {
                return inicio - 1;
            }

            if (raiz.getIzq() == null && raiz.getDer() == null)
            {
                return inicio;
            }

            int nivelIzq = nivelArbol(raiz.getIzq(), inicio + 1);
            int nivelDer = nivelArbol(raiz.getDer(), inicio + 1);

            if (nivelIzq > nivelDer)
            {
                return nivelIzq;
            }
            return nivelDer;
        }

        /*Contar hojas Arbol
        https://codeday.me/es/qa/20190407/439029.html*/
        public int contarHojas(TreeNode<T> nodo)
        {
            if (nodo == null)
            {
                return 0;
            }
            if (nodo.getIzq() == null && nodo.getDer() == null)
            {
                return 1;
            }
            else
            {
                return contarHojas(nodo.getIzq()) + contarHojas(nodo.getDer());
            }
        }

        public void PreOrden(TreeNode<T> r)
        {
            if (r != null)
            {
                Console.WriteLine("[" + r.getDato() + "] ");
                PreOrden(r.getIzq());
                PreOrden(r.getDer());
            }
        }
    }
}