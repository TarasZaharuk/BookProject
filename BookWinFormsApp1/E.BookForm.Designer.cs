
namespace BookWinFormsApp1
{
    partial class BookForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookForm));
            openFileDialog = new OpenFileDialog();
            choseBookComboBox = new ComboBox();
            GetNextPage = new Button();
            textOfPage = new RichTextBox();
            indexOfPage = new TextBox();
            tabControl = new TabControl();
            tabPageCreateBook = new TabPage();
            label3 = new Label();
            LoadBook = new Button();
            DateOfPublishing = new Label();
            InnitTextInPages = new Button();
            label2 = new Label();
            name = new TextBox();
            dateTimePicker = new DateTimePicker();
            Author = new TextBox();
            tabPageViewBook = new TabPage();
            GetPriviousPage = new Button();
            tabControl.SuspendLayout();
            tabPageCreateBook.SuspendLayout();
            tabPageViewBook.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // choseBookComboBox
            // 
            choseBookComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            choseBookComboBox.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            choseBookComboBox.FormattingEnabled = true;
            choseBookComboBox.Location = new Point(47, 8);
            choseBookComboBox.Margin = new Padding(5, 4, 5, 4);
            choseBookComboBox.MinimumSize = new Size(542, 0);
            choseBookComboBox.Name = "choseBookComboBox";
            choseBookComboBox.Size = new Size(542, 58);
            choseBookComboBox.TabIndex = 19;
            // 
            // GetNextPage
            // 
            GetNextPage.Anchor = AnchorStyles.Bottom;
            GetNextPage.BackColor = Color.MediumTurquoise;
            GetNextPage.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GetNextPage.ForeColor = SystemColors.ButtonHighlight;
            GetNextPage.Location = new Point(404, 239);
            GetNextPage.Margin = new Padding(5, 4, 5, 4);
            GetNextPage.MaximumSize = new Size(1571, 346);
            GetNextPage.MinimumSize = new Size(237, 65);
            GetNextPage.Name = "GetNextPage";
            GetNextPage.Size = new Size(237, 67);
            GetNextPage.TabIndex = 4;
            GetNextPage.Text = "Next";
            GetNextPage.UseVisualStyleBackColor = false;
            GetNextPage.Click += GoNextPage_Click;
            // 
            // textOfPage
            // 
            textOfPage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textOfPage.BackColor = SystemColors.ControlLightLight;
            textOfPage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textOfPage.Location = new Point(10, 74);
            textOfPage.Margin = new Padding(5, 4, 5, 4);
            textOfPage.Name = "textOfPage";
            textOfPage.Size = new Size(613, 157);
            textOfPage.TabIndex = 12;
            textOfPage.Text = "";
            // 
            // indexOfPage
            // 
            indexOfPage.Anchor = AnchorStyles.Bottom;
            indexOfPage.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            indexOfPage.Location = new Point(250, 245);
            indexOfPage.Margin = new Padding(5, 4, 5, 4);
            indexOfPage.MaximumSize = new Size(235, 68);
            indexOfPage.Name = "indexOfPage";
            indexOfPage.Size = new Size(144, 61);
            indexOfPage.TabIndex = 13;
            indexOfPage.TextAlign = HorizontalAlignment.Center;
            indexOfPage.TextChanged += IndexOfPage_TextChanged;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPageCreateBook);
            tabControl.Controls.Add(tabPageViewBook);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Margin = new Padding(5, 4, 5, 4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(657, 381);
            tabControl.TabIndex = 20;
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged_1;
            // 
            // tabPageCreateBook
            // 
            tabPageCreateBook.BackColor = Color.LightCyan;
            tabPageCreateBook.Controls.Add(label3);
            tabPageCreateBook.Controls.Add(LoadBook);
            tabPageCreateBook.Controls.Add(DateOfPublishing);
            tabPageCreateBook.Controls.Add(InnitTextInPages);
            tabPageCreateBook.Controls.Add(label2);
            tabPageCreateBook.Controls.Add(name);
            tabPageCreateBook.Controls.Add(dateTimePicker);
            tabPageCreateBook.Controls.Add(Author);
            tabPageCreateBook.Font = new Font("Microsoft Sans Serif", 10.125F);
            tabPageCreateBook.ImeMode = ImeMode.NoControl;
            tabPageCreateBook.Location = new Point(8, 59);
            tabPageCreateBook.Margin = new Padding(5, 4, 5, 4);
            tabPageCreateBook.Name = "tabPageCreateBook";
            tabPageCreateBook.Padding = new Padding(5, 4, 5, 4);
            tabPageCreateBook.Size = new Size(641, 314);
            tabPageCreateBook.TabIndex = 0;
            tabPageCreateBook.Text = "Create Book";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.125F);
            label3.Location = new Point(0, 55);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(86, 31);
            label3.TabIndex = 28;
            label3.Text = "Name";
            // 
            // LoadBook
            // 
            LoadBook.Anchor = AnchorStyles.None;
            LoadBook.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LoadBook.BackColor = Color.Gold;
            LoadBook.Font = new Font("Segoe UI Black", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoadBook.ForeColor = SystemColors.InfoText;
            LoadBook.Location = new Point(-8, -9);
            LoadBook.Margin = new Padding(5, 4, 5, 4);
            LoadBook.MaximumSize = new Size(660, 65);
            LoadBook.MinimumSize = new Size(660, 65);
            LoadBook.Name = "LoadBook";
            LoadBook.RightToLeft = RightToLeft.Yes;
            LoadBook.Size = new Size(660, 65);
            LoadBook.TabIndex = 27;
            LoadBook.Text = "Load Book";
            LoadBook.UseVisualStyleBackColor = false;
            LoadBook.Click += LoadBookButton_Click;
            // 
            // DateOfPublishing
            // 
            DateOfPublishing.Anchor = AnchorStyles.None;
            DateOfPublishing.AutoSize = true;
            DateOfPublishing.Font = new Font("Microsoft Sans Serif", 10.125F);
            DateOfPublishing.Location = new Point(202, 156);
            DateOfPublishing.Margin = new Padding(5, 0, 5, 0);
            DateOfPublishing.Name = "DateOfPublishing";
            DateOfPublishing.RightToLeft = RightToLeft.Yes;
            DateOfPublishing.Size = new Size(226, 31);
            DateOfPublishing.TabIndex = 25;
            DateOfPublishing.Text = "DateOfPublishing";
            // 
            // InnitTextInPages
            // 
            InnitTextInPages.Anchor = AnchorStyles.None;
            InnitTextInPages.BackColor = Color.Gold;
            InnitTextInPages.Enabled = false;
            InnitTextInPages.Font = new Font("Segoe UI Black", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InnitTextInPages.ForeColor = SystemColors.InfoText;
            InnitTextInPages.Location = new Point(-11, 249);
            InnitTextInPages.Margin = new Padding(5, 4, 5, 4);
            InnitTextInPages.MaximumSize = new Size(660, 65);
            InnitTextInPages.MinimumSize = new Size(660, 65);
            InnitTextInPages.Name = "InnitTextInPages";
            InnitTextInPages.RightToLeft = RightToLeft.Yes;
            InnitTextInPages.Size = new Size(660, 65);
            InnitTextInPages.TabIndex = 20;
            InnitTextInPages.Text = "Create Book";
            InnitTextInPages.UseVisualStyleBackColor = false;
            InnitTextInPages.Click += InitTextInPagesButton_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.125F);
            label2.Location = new Point(458, 68);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(94, 31);
            label2.TabIndex = 24;
            label2.Text = "Author";
            // 
            // name
            // 
            name.Anchor = AnchorStyles.None;
            name.Enabled = false;
            name.Font = new Font("Microsoft Sans Serif", 10.125F);
            name.ForeColor = SystemColors.WindowText;
            name.Location = new Point(0, 103);
            name.Margin = new Padding(5, 4, 5, 4);
            name.MaximumSize = new Size(300, 38);
            name.MinimumSize = new Size(300, 38);
            name.Name = "name";
            name.RightToLeft = RightToLeft.Yes;
            name.Size = new Size(300, 38);
            name.TabIndex = 21;
            name.TextAlign = HorizontalAlignment.Center;
            name.TextChanged += Name_TextChanged;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Anchor = AnchorStyles.None;
            dateTimePicker.CalendarFont = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker.Font = new Font("Microsoft Sans Serif", 10.125F);
            dateTimePicker.Location = new Point(0, 206);
            dateTimePicker.Margin = new Padding(5, 4, 5, 4);
            dateTimePicker.MaxDate = new DateTime(2024, 1, 22, 0, 0, 0, 0);
            dateTimePicker.MaximumSize = new Size(640, 40);
            dateTimePicker.MinimumSize = new Size(640, 40);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.RightToLeft = RightToLeft.Yes;
            dateTimePicker.Size = new Size(640, 40);
            dateTimePicker.TabIndex = 26;
            dateTimePicker.Value = new DateTime(2024, 1, 22, 0, 0, 0, 0);
            // 
            // Author
            // 
            Author.Anchor = AnchorStyles.None;
            Author.Font = new Font("Microsoft Sans Serif", 10.125F);
            Author.Location = new Point(340, 103);
            Author.Margin = new Padding(5, 4, 5, 4);
            Author.MaximumSize = new Size(300, 38);
            Author.MinimumSize = new Size(300, 38);
            Author.Name = "Author";
            Author.RightToLeft = RightToLeft.Yes;
            Author.Size = new Size(300, 38);
            Author.TabIndex = 22;
            Author.TextAlign = HorizontalAlignment.Center;
            Author.TextChanged += Author_TextChanged;
            // 
            // tabPageViewBook
            // 
            tabPageViewBook.BackColor = Color.LemonChiffon;
            tabPageViewBook.Controls.Add(choseBookComboBox);
            tabPageViewBook.Controls.Add(GetPriviousPage);
            tabPageViewBook.Controls.Add(GetNextPage);
            tabPageViewBook.Controls.Add(indexOfPage);
            tabPageViewBook.Controls.Add(textOfPage);
            tabPageViewBook.Location = new Point(8, 59);
            tabPageViewBook.Margin = new Padding(5, 4, 5, 4);
            tabPageViewBook.Name = "tabPageViewBook";
            tabPageViewBook.Padding = new Padding(5, 4, 5, 4);
            tabPageViewBook.Size = new Size(641, 314);
            tabPageViewBook.TabIndex = 1;
            tabPageViewBook.Text = "View Book";
            // 
            // GetPriviousPage
            // 
            GetPriviousPage.Anchor = AnchorStyles.Bottom;
            GetPriviousPage.BackColor = Color.MediumTurquoise;
            GetPriviousPage.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GetPriviousPage.ForeColor = SystemColors.ControlLightLight;
            GetPriviousPage.Location = new Point(5, 241);
            GetPriviousPage.Margin = new Padding(5, 4, 5, 4);
            GetPriviousPage.MaximumSize = new Size(1571, 346);
            GetPriviousPage.MinimumSize = new Size(237, 65);
            GetPriviousPage.Name = "GetPriviousPage";
            GetPriviousPage.Size = new Size(237, 65);
            GetPriviousPage.TabIndex = 3;
            GetPriviousPage.Text = "Back";
            GetPriviousPage.TextAlign = ContentAlignment.TopCenter;
            GetPriviousPage.UseVisualStyleBackColor = false;
            GetPriviousPage.Click += GoPriviousPage_Click;
            // 
            // BookForm
            // 
            AutoScaleDimensions = new SizeF(20F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 381);
            Controls.Add(tabControl);
            Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MaximumSize = new Size(683, 452);
            MinimumSize = new Size(683, 452);
            Name = "BookForm";
            tabControl.ResumeLayout(false);
            tabPageCreateBook.ResumeLayout(false);
            tabPageCreateBook.PerformLayout();
            tabPageViewBook.ResumeLayout(false);
            tabPageViewBook.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private OpenFileDialog openFileDialog;
        private ComboBox choseBookComboBox;
        private Button GetNextPage;
        private RichTextBox textOfPage;
        private TextBox indexOfPage;
        private TabControl tabControl;
        private TabPage tabPageCreateBook;
        private TabPage tabPageViewBook;
        private Button GetPriviousPage;
        private Button LoadBook;
        private Label DateOfPublishing;
        private Button InnitTextInPages;
        private Label label2;
        private TextBox name;
        private DateTimePicker dateTimePicker;
        private TextBox Author;
        private Label label3;
    }
}
