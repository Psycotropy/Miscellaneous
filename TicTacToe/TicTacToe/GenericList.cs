using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class GenericList<T> 
    {
        public GenericList()
        {
            TempList = new List<T>();
            ResetList();
            
           
        }

        public int getLenght()
        {
            return this.TempList.Count;
        }


        public void setValues(ref T element, int lenght)
        {
            //MessageBox.Show("El largo de la lista recibida es : " + lenght);
           
            TempList.Add(element);
            //MessageBox.Show("Se agregado en genericList el valor : " + element);
            
        }

        public void setValue(T element)
        {
            //MessageBox.Show("se a añadido  el random : " + element);
            TempList.Add(element);
        }

        public void printList()
        {
            foreach(T t in TempList)
            {
                MessageBox.Show("La tempList tiene el valor de : " + t);
            }
            MessageBox.Show("La tempList tiene un largo de : " + TempList.Count);
            
        }

        private void ResetList()
        {
            TempList.Clear();
        }

        public bool repitance(T element)
        {
            if (TempList.Contains(element))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        



        List<T> TempList;
    }

    

    public sealed class IntMethods : GenericList<int>
    {
        /// <summary>
        /// this class is used to store int methods that uses the generic temp list
        /// </summary>
        /// <returns></returns>

        public int Play()
        {

            if (getLenght() == 1)
            {
                do
                {
                    numeroAleatorio = new Random().Next(1, 9);
                    //MessageBox.Show("temporal : " + numeroAleatorio);
                } while (repitance(numeroAleatorio) == false);
            }
            else
            {
                while (repitance(numeroAleatorio) == false)
                {
                    numeroAleatorio = new Random().Next(1, 9);
                    //MessageBox.Show("temporal : " + numeroAleatorio);
                }
            }


            
                
            

            setValue(numeroAleatorio);
            return numeroAleatorio;

            
           
        

        }

        int numeroAleatorio;

    }
    
}
