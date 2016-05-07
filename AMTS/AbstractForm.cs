using System.Windows.Forms;

namespace AMTS
{
    public partial class AbstractForm : Form
    {
        protected bool openedWindow = false;
        public void changeOpenedWindow()
        {
            openedWindow = !openedWindow;
        }
        public AbstractForm()
        {
            InitializeComponent();
        }
    }
}
