﻿using System;
using System.Diagnostics;
using System.IO;
using System.Windows;
using Sudoku.ViewModels;

namespace Sudoku.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string[] args = Environment.GetCommandLineArgs();

            if (args.Length == 2)
            {
                if ((Path.GetExtension(args[1]) == PuzzleViewModel.cDefaultFileExt) && File.Exists(args[1]))
                {
                    try
                    {
                        ((PuzzleViewModel)DataContext).OpenFile(File.OpenRead(args[1]), args[1]);
                    }
                    catch    // this is not production quality code
                    {
                    }
                }
            }
        }
    }
}
