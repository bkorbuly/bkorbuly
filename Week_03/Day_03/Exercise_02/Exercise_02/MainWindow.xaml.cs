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

namespace Exercise_02
{
    
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            var pointList = new List<Point>()
            {
                new Point(10, 10),
                new Point(50, 10),
                new Point(50, 50),
                new Point(10, 50),
            };
            foxDraw.FillColor(Colors.Black);
            foxDraw.DrawPolygon(pointList);
        }
    }
}
