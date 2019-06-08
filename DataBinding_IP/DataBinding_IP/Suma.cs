using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBinding_IP
{
    class Suma : INotifyPropertyChanged
    {
        private String primerNumero;
        private String segundoNumero;
        private String resultado;
     
        private String PrimerNumero
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

        private String SegundoNumero
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
