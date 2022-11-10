using MetroFramework.Controls;

namespace IFrameUploader
{
    public partial class InfoControl : MetroUserControl
    {
        private readonly IFrameWindow _parent;
        public InfoControl(IFrameWindow parent)
        {
            _parent = parent;
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, System.EventArgs e)
        {
            new SettingsForm().ShowDialog();
            _parent.SetDataSource();
        }

        private void metroTile2_Click(object sender, System.EventArgs e)
        {
            _parent.ImportSettings();
        }
    }
}
