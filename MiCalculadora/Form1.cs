using Entidades;
namespace MiCalculadora
{
    public partial class FrmCalculadora : Form
    {
        private Operacion calculadora;
        private Numeracion primerOperando;
        private Numeracion segundoOperando;
        private Numeracion resultado;
        private Numeracion.ESistema sistema;

        public FrmCalculadora()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cmbOperacion.Items.AddRange(new object[] { '+', '-', '/', '*' });
            this.rdbDecimal.Checked = true;
            
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtPrimerOperador.Clear();
            this.txtSegundoOperador.Clear();
            this.resultado = null;
            lblResultado.Text = "Resultado:";
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            char operador = cmbOperacion.Text.FirstOrDefault();

            if (txtPrimerOperador.Text != string.Empty && txtSegundoOperador.Text != string.Empty)
            {
                Operacion nuevaOperacion = new Operacion(this.primerOperando, this.segundoOperando);
                this.resultado = nuevaOperacion.Operar(operador);
                MessageBox.Show(this.primerOperando.Valor);
                MessageBox.Show(this.segundoOperando.Valor);
                setResultado();

            }
            else
            {
                MessageBox.Show("Debes ingresas valores\npara ambos operadores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea cerrar la calculadora?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBinario.Checked)
            {
                this.sistema = Numeracion.ESistema.Binario;
                setResultado();
            }
        }

        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDecimal.Checked)
            {
                this.sistema = Numeracion.ESistema.Decimal;
                setResultado();
            }
        }

        private void setResultado()
        {
            if(this.resultado is not null)
            {
                lblResultado.Text = $"Resultado: {this.resultado.ConvertirA(this.sistema)}";
            }         
        }

        private void txtPrimerOperador_TextChanged(object sender, EventArgs e)
        {
            double numeroIngresado;
            double.TryParse(txtPrimerOperador.Text, out numeroIngresado);

            this.primerOperando = new Numeracion(numeroIngresado, Numeracion.ESistema.Decimal);
        }
        private void txtSegundoOperador_TextChanged(object sender, EventArgs e)
        {
            double numeroIngresado;
            double.TryParse(txtSegundoOperador.Text, out numeroIngresado);

            this.segundoOperando = new Numeracion(numeroIngresado, Numeracion.ESistema.Decimal);
        }
    }
}