using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultaCEP {
    public partial class FrmConsultaCEP : Form {
        public FrmConsultaCEP() {
            InitializeComponent();
        }

        private void btnConsult_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(txtZipCode.Text)) {
                using (var ws = new WsCorreios.AtendeClienteClient()) {
                    try {
                        var address = ws.consultaCEP(txtZipCode.Text.Trim());
                        txtStreetName.Text = address.end;
                        txtDistrict.Text = address.bairro;
                        txtCity.Text = address.bairro;
                        txtState.Text = address.uf;
                    } catch (Exception exception) {
                        MessageBox.Show(exception.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } else {
                MessageBox.Show("Informe um cep válido...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClean_Click(object sender, EventArgs e) {
            txtZipCode.Text = string.Empty;
            txtStreetName.Text = string.Empty;
            txtState.Text = string.Empty;
            txtDistrict.Text = string.Empty;
            txtCity.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
