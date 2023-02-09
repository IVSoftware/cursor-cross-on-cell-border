namespace cursor_cross_on_cell_border
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // MainForm has ARROW
            this.Cursor = Cursors.Arrow;

            // TableLayoutPanel has CROSS
            tableLayoutPanel.Cursor = Cursors.Cross;

            for (int column = 0; column < tableLayoutPanel.ColumnCount; column++)
                for (int row = 0; row < tableLayoutPanel.RowCount; row++)
                {
                    tableLayoutPanel.Controls.Add(new Panel
                    {
                        BackColor = Color.LightGreen,
                        Anchor = (AnchorStyles)0xF,
                        Margin = new Padding(10),

                        // Controls in the table have HAND
                        Cursor = Cursors.Hand,
                    });
                }
        }

        int _wdtCount = 0;
        private void onResized(object? sender, EventArgs e)
        {
            var capture = ++_wdtCount;
            Task
                .Delay(2500)
                .GetAwaiter()
                .OnCompleted(() =>
                {
                    if (capture.Equals(_wdtCount))
                    {

                    }
                });
        }
    }
}