using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvinhaONumero
{
    public partial class frmPrincipal : Form
    {
        private Random random;
        private int intNumeroAleatorio;

        public frmPrincipal()
        {
            InitializeComponent();

            random = new Random();
            intNumeroAleatorio = random.Next(0, 101);
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int intNumeroIntroduzido = Convert.ToInt16(nudNumero.Value);

            if(intNumeroIntroduzido > intNumeroAleatorio)
            {
                DialogResult result = MessageBox.Show("O número introduzido é maior que o gerado. Quer tentar outra vez?", "Você errou!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                if(result == DialogResult.Cancel)
                {
                    MessageBox.Show($"O número era {intNumeroAleatorio}. Espero que pela próxima você consiga acertar.", "Que pena!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    intNumeroAleatorio = random.Next(0, 101);
                }
            }
            else if (intNumeroIntroduzido < intNumeroAleatorio)
            {
                DialogResult result = MessageBox.Show("O número introduzido é menor que o gerado. Quer tentar outra vez?", "Você errou!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                if (result == DialogResult.Cancel)
                {
                    MessageBox.Show($"O número era {intNumeroAleatorio}. Espero que pela próxima você consiga acertar.", "Que pena!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    intNumeroAleatorio = random.Next(0, 101);
                }
            }
            else
            {
                MessageBox.Show($"Muitos parabéns, o número era mesmo {intNumeroAleatorio}.", "Você acertou!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                intNumeroAleatorio = random.Next(0, 101);
            }
        }
    }
}
