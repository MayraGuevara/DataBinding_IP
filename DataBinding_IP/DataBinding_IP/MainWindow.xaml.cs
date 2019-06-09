﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataBinding_IP
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {  

        public Suma Lasuma { get; set; }

        public MainWindow()
        {

            InitializeComponent();
            Lasuma = new Suma { PrimerNumero = "1", SegundoNumero = "2" };
            this.Content = Lasuma;
           
        }


      
    }

       
    }

