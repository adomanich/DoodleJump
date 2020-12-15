using DoodleJump.db;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;
 
namespace DoodleJump
{
    /// <summary>
    /// Interaction logic for Score_Window.xaml
    /// </summary>
    public partial class Score_Window : Window
    {
        private System.Collections.ObjectModel.ObservableCollection<Score> _scores;
        public ScoreContext _scoreContext;
        public Score_Window()
        {
            InitializeComponent();

            _scoreContext = new ScoreContext();
            _scores = new ObservableCollection<Score>(_scoreContext.Set<Score>().Take(10).ToList());
            tasks.ItemsSource = _scores;
        }
    }
}
