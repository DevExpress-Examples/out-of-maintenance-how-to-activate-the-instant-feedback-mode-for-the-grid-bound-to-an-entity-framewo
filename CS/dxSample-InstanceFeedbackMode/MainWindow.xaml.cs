using System.Windows;
using DevExpress.Data.Linq;
using DevExpress.Xpf.Grid;

namespace dxSample_InstanceFeedbackMode {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        NorthwindEntities dataContext;
        public MainWindow() {
            InitializeComponent();
            dataContext = new NorthwindEntities();
            entitySource.QueryableSource = dataContext.Products;
        }
    }
}
