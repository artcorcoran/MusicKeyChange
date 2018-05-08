// Copyright (c) 2016 by Art Corcoran.  All rights reserved.

using System;
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

namespace MusicKeyChange
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static Dictionary<String, List<String>> _keyValues = new Dictionary<string, List<string>>();

        public MainWindow()
        {
            InitializeComponent();

            _keyValues.Add("C",  new List<String>() { "C",  "D",  "E",  "F",  "G",  "A",  "B"  });
            _keyValues.Add("C#", new List<String>() { "C#", "D#", "E#", "F#", "G#", "A#", "B#" });
            _keyValues.Add("Db", new List<String>() { "Db", "Eb", "F",  "Gb", "Ab", "Bb", "C"  });
            _keyValues.Add("D",  new List<String>() { "D",  "E",  "F#", "G",  "A",  "B",  "C#" });
            _keyValues.Add("Eb", new List<String>() { "Eb", "F",  "G",  "Ab", "Bb", "C",  "D"  });
            _keyValues.Add("E",  new List<String>() { "E",  "F#", "G#", "A",  "B",  "C#", "D#" });
            _keyValues.Add("F",  new List<String>() { "F",  "G",  "A",  "Bb", "C",  "D",  "E"  });
            _keyValues.Add("F#", new List<String>() { "F#", "G#", "A#", "B",  "C#", "D#", "E#" });
            _keyValues.Add("Gb", new List<String>() { "Gb", "Ab", "Bb", "Cb", "Db", "Eb", "F"  });
            _keyValues.Add("G",  new List<String>() { "G",  "A",  "B",  "C",  "D",  "E",  "F#" });
            _keyValues.Add("Ab", new List<String>() { "Ab", "Bb", "C",  "Db", "Eb", "F",  "G"  });
            _keyValues.Add("A",  new List<String>() { "A",  "B",  "C#", "D",  "E",  "F#", "G#" });
            _keyValues.Add("Bb", new List<String>() { "Bb", "C",  "D",  "Eb", "F",  "G",  "A"  });
            _keyValues.Add("B",  new List<String>() { "B",  "C#", "D#", "E",  "F#", "G#", "A#" });

            drpSourceKey.SelectionChanged += drpSourceKey_SelectionChanged;
            drpDestKey.SelectionChanged += drpDestKey_SelectionChanged;
        }

        void drpSourceKey_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var val = drpSourceKey.SelectedValue.ToString();
            var vals = _keyValues[val];
            txtSrc0.Text = vals[0];
            txtSrc1.Text = vals[1];
            txtSrc2.Text = vals[2];
            txtSrc3.Text = vals[3];
            txtSrc4.Text = vals[4];
            txtSrc5.Text = vals[5];
            txtSrc6.Text = vals[6];
        }

        void drpDestKey_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var val = drpDestKey.SelectedValue.ToString();
            var vals = _keyValues[val];
            txtDst0.Text = vals[0];
            txtDst1.Text = vals[1];
            txtDst2.Text = vals[2];
            txtDst3.Text = vals[3];
            txtDst4.Text = vals[4];
            txtDst5.Text = vals[5];
            txtDst6.Text = vals[6];
        }

    }
}
