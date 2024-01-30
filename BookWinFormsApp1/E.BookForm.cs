using BookProject;
using Microsoft.VisualBasic;
using System.Windows.Forms.Design;

namespace BookWinFormsApp1
{
    public partial class BookForm : Form
    {
        private int _index;
        private string? _path;
        List<Book> books = new List<Book>();
        public BookForm()
        {
            InitializeComponent();
        }
        private void GoPriviousPage_Click(object sender, EventArgs e) //rename
        {
            if (_index > 0)
            {
                _index--;
                GetNextPage.Enabled = true;
                indexOfPage.Text = _index.ToString();
            }
            else
            {
                GetPriviousPage.Enabled = false;
            }
            textOfPage.Text = books[choseBookComboBox.SelectedIndex].GetText(_index);
        }

        private void GoNextPage_Click(object sender, EventArgs e)
        {
            if (_index < books[choseBookComboBox.SelectedIndex].CountOfPages)
            {
                GetPriviousPage.Enabled = true;
                textOfPage.Text = books[choseBookComboBox.SelectedIndex].GetText(_index);
                indexOfPage.Text = _index.ToString();
                _index++;
            }
            else
            {
                GetNextPage.Enabled = false;
                _index--;
            }
        }

        private void IndexOfPage_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(indexOfPage.Text, out _index);
            if (_index >= 0 && _index <= books[choseBookComboBox.SelectedIndex].CountOfPages)
            {
                textOfPage.Text = books[choseBookComboBox.SelectedIndex].GetText(_index);
            }
        }
        private void InitTextInPagesButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(name.Text) && !string.IsNullOrWhiteSpace(_path) && !string.IsNullOrWhiteSpace(Author.Text))
            {
                using StreamReader streamReader = new StreamReader(_path);
                string text = streamReader.ReadToEnd();
                books.Add(new Book(name.Text, text, Author.Text, DateOnly.FromDateTime(dateTimePicker.Value)));
                choseBookComboBox.Items.Add(name.Text);
                choseBookComboBox.SelectedItem = choseBookComboBox.Items[0];
                indexOfPage.Text = "0";
                tabControl.SelectTab(tabPageViewBook);
                MaximumSize = new Size();
            }
        }

        private void LoadBookButton_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "txt files (*.txt)|*.txt";
            openFileDialog.ShowDialog();
            name.Text = openFileDialog.SafeFileName.Replace(".txt","");
            _path = openFileDialog.FileName;
            if (!string.IsNullOrWhiteSpace(_path))
            {
                if (!string.IsNullOrWhiteSpace(Author.Text))
                {
                    InnitTextInPages.Enabled = true;
                }
                name.Enabled = true;
            }
        }
        private void Name_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(name.Text) && !string.IsNullOrWhiteSpace(_path) && !string.IsNullOrWhiteSpace(Author.Text))
                InnitTextInPages.Enabled = true;
            else
                InnitTextInPages.Enabled = false;
        }

        private void Author_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(name.Text) && !string.IsNullOrWhiteSpace(_path) && !string.IsNullOrWhiteSpace(Author.Text))
                InnitTextInPages.Enabled = true;
            else
                InnitTextInPages.Enabled = false;
        }
        private void tabControl_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (choseBookComboBox.Items.Count == 0)
                tabControl.SelectTab(tabPageCreateBook);
            if (tabControl.SelectedTab == tabPageCreateBook)
                MaximumSize = new Size(683, 452);
            else
                MaximumSize = new Size();
        }
    }
}
