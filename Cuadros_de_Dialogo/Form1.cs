namespace Cuadros_de_Dialogo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Mensaje a Mostrar", "Título", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Seleccionaste que SI.");
            }
            else
            {
                MessageBox.Show("Seleccionaste que NO.");
            }
        }
    }
}
