using Fiscal.Properties;

namespace Fiscal {
    public partial class Fiscal : Form {
        public Fiscal() {
            InitializeComponent();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e) {
        }

        public void btnSped_Click(object sender, EventArgs e) {
          
            SpedForm sped = new SpedForm();
            sped.ShowDialog();
        }
    }
}
