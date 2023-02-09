If I get what you're asking, provided you have controls in the cells of the `TableLayoutPanel` all one would have to do is set the different cursors one time for:

- Main form (Arrow)
- Table layout panel (Cross)
- The controls therein contained (e.g. Hand)

[![screenshot][1]][1]

Everything else should happen on its own.
 
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


  [1]: https://i.stack.imgur.com/1syA7.png