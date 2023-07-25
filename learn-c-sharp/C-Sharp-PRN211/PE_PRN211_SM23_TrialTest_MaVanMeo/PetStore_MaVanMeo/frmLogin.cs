using PetStore_MaVanMeo_Repository.Repository;
namespace PetStore_MaVanMeo
{
    public partial class frmLogin : Form
    {
        private IMemberRepository _memberRepository;
        public frmLogin()
        {
            _memberRepository = new MemberPetShop();
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //check xem null
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Ban phai nhap User Name");
                txtUserName.Focus();
                return;
            }
               
            
            if (txtPass.Text == "")
            {
                MessageBox.Show("Ban phai nhap Mat khau");
                txtPass.Focus();
                return;
            }
                
            //check mat khau va user
            var member = _memberRepository.GetMembers()
                .FirstOrDefault(m => m.EmailAddress == txtUserName.Text && m.MemberPassword == txtPass.Text);

            if (member == null)
            {
                MessageBox.Show("Email or Pass invalid...");
            }
            else
            {
                if (member.MemberRole==2)
                {
                    frmPetManagement frmPet = new();
                    frmPet.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Ban khong co quyen");
                }
                
            }
        }
    }
}