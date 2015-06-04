using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    class Arbol
    {
        public Nodo raiz;
        
        public void agregar(Nodo nuevo)
        {
            if (raiz == null)
                raiz = nuevo;
            else
                agregar(nuevo, raiz);
        }

        private void agregar(Nodo n, Nodo r)
        {
            if (n.dato < r.dato)
                if (r.hIzq == null)
                    r.hIzq = n;
                else
                    agregar(n, r.hIzq);
            else
                if (r.hDer == null)
                    r.hDer = n;
                else
                    agregar(n, r.hDer);
        }

        public string inOrder()
        {
            string cadenita = "";
            if (raiz != null)
                cadenita = inOrder(raiz);
            return cadenita;
        }

        private string inOrder(Nodo r)
        {
            string cadenita = "";
            if (r.hIzq != null)
                cadenita += inOrder(r.hIzq);
            cadenita += r.ToString() + " ";
            if (r.hDer != null)
                cadenita += inOrder(r.hDer);
            return cadenita;
        }

        public string preOrder()
        {
            string cadenita = "";
            if (raiz != null)
                cadenita = preOrder(raiz);
            return cadenita;
        }

        private string preOrder(Nodo r)
        {
            string cadenita = "";

            cadenita += r.ToString() + " ";

            if (r.hIzq != null)
                cadenita += preOrder(r.hIzq);
            
            if (r.hDer != null)
                cadenita += preOrder(r.hDer);

            return cadenita;
        }

        public string postOrder()
        {
            string cadenita = "";
            if (raiz != null)
                cadenita = postOrder(raiz);
            return cadenita;
        }

        private string postOrder(Nodo r)
        {
            string cadenita = "";

            if (r.hIzq != null)
                cadenita += postOrder(r.hIzq);

            if (r.hDer != null)
                cadenita += postOrder(r.hDer);

            cadenita += r.ToString() + " ";

            return cadenita;
        }

        public Nodo buscar(int dato)
        {
            if (raiz != null)
                return buscar(dato, raiz);
            else
                return null;
        }

        public Nodo buscar(int dato, Nodo raiz)
        {
            if (raiz.dato == dato)
                return raiz;
            else if (raiz.hIzq != null && dato < raiz.dato)
            {
                return buscar(dato, raiz.hIzq);
            }
            else if (raiz.hDer != null)
            {
                return buscar(dato, raiz.hDer);
            }
            else
                return null;
        }
    }
}
