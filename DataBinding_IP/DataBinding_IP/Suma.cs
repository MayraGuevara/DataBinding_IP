using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBinding_IP
{
   public class Suma : INotifyPropertyChanged
    {
        private String primerNumero;
        private String segundoNumero;
        private String resultado;
     
        public String PrimerNumero
        {
            get { return primerNumero; }
            set
            {
                int Numero;
                bool resultado = int.TryParse(value, out Numero);  //tryParse intenta convertirlo en entero
                if (resultado)
                {
                    primerNumero = value;
                }

                OnPropertyChanged("PrimerNumero");
                OnPropertyChanged("Reultado");

            }
        }

        public String SegundoNumero
        {
            get { return segundoNumero; }
            set
            {
                int Numero;
                bool resultado = int.TryParse(value, out Numero);  //tryParse intenta convertirlo en entero
                if (resultado)
                {
                    segundoNumero = value;
                }

                OnPropertyChanged("SegundoNumero");
                OnPropertyChanged("Reultado");

            }
        }

        public string Resultado
        {
            get
            {
                int resutado = int.Parse(PrimerNumero) + int.Parse(SegundoNumero);
                return resultado.ToString();
            }

            set
            {
                int suma = int.Parse(PrimerNumero) + int.Parse(SegundoNumero);
                resultado = suma.ToString();
                OnPropertyChanged("Resultado");
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(String property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }

    
    
}
