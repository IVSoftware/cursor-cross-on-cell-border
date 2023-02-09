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

            int key = 0; string text;
            for (int column = 0; column < tableLayoutPanel.ColumnCount; column++)
                for (int row = 0; row < tableLayoutPanel.RowCount; row++)
                {
                    switch (++key)
                    {
                        case 10: text = "*"; break;
                        case 11: text = "0"; break;
                        case 12: text = "#"; break;
                        default: text = $"{key}";  break;
                    }
                    tableLayoutPanel.Controls.Add(new Label
                    {
                        BackColor = Color.LightGreen,
                        Anchor = (AnchorStyles)0xF,
                        Margin = new Padding(10),  
                        Text = text,
                        TextAlign = ContentAlignment.MiddleCenter,

                        // Controls in the table have HAND
                        Cursor = Cursors.Hand,
                    });
                }
        }
    }
}