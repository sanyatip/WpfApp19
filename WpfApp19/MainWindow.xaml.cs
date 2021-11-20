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
using System.Windows.Forms.DataVisualization.Charting;

namespace WpfApp19
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitialChart();
        }
        public void InitialChart()
        {
            ChartLes.ChartAreas.Add(new ChartArea("original"));
            string[] NameCar = { "Audi", "BMW", "Toyota", "SUZUKI" };
            int[] CountCar = { 5, 9, 7, 8 };

            ChartLes.Palette = ChartColorPalette.Berry;

            ChartLes.Titles.Add("Парк Машин");
            for (int i = 0; i < NameCar.Length; i++)
            {
                Series series = ChartLes.Series.Add(NameCar[i]);
                series.Points.Add(CountCar[i]);
            }
        }


    }
}
