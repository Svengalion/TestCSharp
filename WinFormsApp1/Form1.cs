using ClassLibrary1;

namespace WinFormsApp1
{
    public partial class Form1 : Form, IUserInfo
    {
        private UserInfoPresenter _presenter;
        public Form1()
        {
            InitializeComponent();
            this._presenter = new UserInfoPresenter(this);
        }

        public string FirstName { get => this.tbName.Text; set => this.tbName.Text = value; }
        public string LastName { get => this.tbLastName.Text; set => this.tbLastName.Text = value; }
        public string Email { get => this.tbEmail.Text; set => this.tbEmail.Text = value; }
        public string ErrorMessage { get => this.lbErrorMessage.Text; set => this.lbErrorMessage.Text = value; }
        public bool ShowFormErrors { get => this.lbErrorMessage.Visible; set => this.lbErrorMessage.Visible = value; }

        public event EventHandler? SaveAttempted;

        private void btSave_Click(object sender, EventArgs e)
        {
            SaveAttempted?.Invoke(this, EventArgs.Empty);
        }
    }
}