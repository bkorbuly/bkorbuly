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
using GreenFox;

namespace Exercise_06
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            var points = new List<Point>()
            {
                new Point(140 , 140),
                new Point(160 , 140),
                new Point(160 , 160),
                new Point(140 , 160) 
            };
            foxDraw.FillColor(Colors.Green);
            foxDraw.DrawPolygon(points);
        }
    }
}
