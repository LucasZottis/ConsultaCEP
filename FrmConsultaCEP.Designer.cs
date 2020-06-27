namespace ConsultaCEP {
    partial class FrmConsultaCEP {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.zipCode = new System.Windows.Forms.Label();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.state = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.Label();
            this.txtDistrict = new System.Windows.Forms.TextBox();
            this.district = new System.Windows.Forms.Label();
            this.txtStreetName = new System.Windows.Forms.TextBox();
            this.streetName = new System.Windows.Forms.Label();
            this.btnConsult = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // zipCode
            // 
            this.zipCode.AutoSize = true;
            this.zipCode.ForeColor = System.Drawing.Color.White;
            this.zipCode.Location = new System.Drawing.Point(11, 9);
            this.zipCode.Name = "zipCode";
            this.zipCode.Size = new System.Drawing.Size(28, 13);
            this.zipCode.TabIndex = 0;
            this.zipCode.Text = "CEP";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(14, 25);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(100, 20);
            this.txtZipCode.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtState);
            this.groupBox1.Controls.Add(this.state);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.city);
            this.groupBox1.Controls.Add(this.txtDistrict);
            this.groupBox1.Controls.Add(this.district);
            this.groupBox1.Controls.Add(this.txtStreetName);
            this.groupBox1.Controls.Add(this.streetName);
            this.groupBox1.Location = new System.Drawing.Point(14, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 182);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço";
            // 
            // txtState
            // 
            this.txtState.BackColor = System.Drawing.Color.LightGray;
            this.txtState.Location = new System.Drawing.Point(6, 149);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(544, 20);
            this.txtState.TabIndex = 1;
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.ForeColor = System.Drawing.Color.White;
            this.state.Location = new System.Drawing.Point(9, 133);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(40, 13);
            this.state.TabIndex = 0;
            this.state.Text = "Estado";
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.LightGray;
            this.txtCity.Location = new System.Drawing.Point(6, 110);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(544, 20);
            this.txtCity.TabIndex = 1;
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.ForeColor = System.Drawing.Color.White;
            this.city.Location = new System.Drawing.Point(9, 94);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(40, 13);
            this.city.TabIndex = 0;
            this.city.Text = "Cidade";
            // 
            // txtDistrict
            // 
            this.txtDistrict.BackColor = System.Drawing.Color.LightGray;
            this.txtDistrict.Location = new System.Drawing.Point(6, 71);
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Size = new System.Drawing.Size(544, 20);
            this.txtDistrict.TabIndex = 1;
            // 
            // district
            // 
            this.district.AutoSize = true;
            this.district.ForeColor = System.Drawing.Color.White;
            this.district.Location = new System.Drawing.Point(9, 55);
            this.district.Name = "district";
            this.district.Size = new System.Drawing.Size(34, 13);
            this.district.TabIndex = 0;
            this.district.Text = "Bairro";
            // 
            // txtStreetName
            // 
            this.txtStreetName.BackColor = System.Drawing.Color.LightGray;
            this.txtStreetName.Location = new System.Drawing.Point(6, 32);
            this.txtStreetName.Name = "txtStreetName";
            this.txtStreetName.Size = new System.Drawing.Size(544, 20);
            this.txtStreetName.TabIndex = 1;
            // 
            // streetName
            // 
            this.streetName.AutoSize = true;
            this.streetName.ForeColor = System.Drawing.Color.White;
            this.streetName.Location = new System.Drawing.Point(9, 16);
            this.streetName.Name = "streetName";
            this.streetName.Size = new System.Drawing.Size(61, 13);
            this.streetName.TabIndex = 0;
            this.streetName.Text = "Logradouro";
            // 
            // btnConsult
            // 
            this.btnConsult.BackgroundImage = global::ConsultaCEP.Properties.Resources.busca_cep;
            this.btnConsult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsult.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnConsult.FlatAppearance.BorderSize = 2;
            this.btnConsult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsult.Location = new System.Drawing.Point(349, 9);
            this.btnConsult.Name = "btnConsult";
            this.btnConsult.Size = new System.Drawing.Size(218, 53);
            this.btnConsult.TabIndex = 2;
            this.btnConsult.UseVisualStyleBackColor = true;
            this.btnConsult.Click += new System.EventHandler(this.btnConsult_Click);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClean.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnClean.FlatAppearance.BorderSize = 2;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.ForeColor = System.Drawing.Color.White;
            this.btnClean.Image = global::ConsultaCEP.Properties.Resources.limpar;
            this.btnClean.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClean.Location = new System.Drawing.Point(159, 256);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(100, 25);
            this.btnClean.TabIndex = 3;
            this.btnClean.Text = "Limpar";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::ConsultaCEP.Properties.Resources.sair;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(325, 256);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 25);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmConsultaCEP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(583, 291);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnConsult);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.zipCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmConsultaCEP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar CEP";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label zipCode;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.TextBox txtDistrict;
        private System.Windows.Forms.Label district;
        private System.Windows.Forms.TextBox txtStreetName;
        private System.Windows.Forms.Label streetName;
        private System.Windows.Forms.Button btnConsult;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnExit;
    }
}

