namespace pryDulceria
{
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();

        }
        private void btnAcceder_Click_1(object sender, EventArgs e)
        {
            try
            {
                clsInicioSesion login = new clsInicioSesion();
                login.Usuario = txtUsuario.Text;
                login.Password = txtContraseña.Text;

                bool resp = login.ValidarAcceso();
                if (resp == true)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close(); // Cierra el login y abre el formulario principal
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
