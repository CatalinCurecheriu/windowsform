
namespace WFSQL
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.proprietariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provaDataSet4 = new WFSQL.ProvaDataSet4();
            this.proprietariTableAdapter = new WFSQL.ProvaDataSet4TableAdapters.ProprietariTableAdapter();
            this.provaDataSet1 = new WFSQL.ProvaDataSet1();
            this.immobiliBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.immobiliTableAdapter1 = new WFSQL.ProvaDataSet1TableAdapters.ImmobiliTableAdapter();
            this.immobiliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provaDataSet = new WFSQL.ProvaDataSet();
            this.immobiliTableAdapter = new WFSQL.ProvaDataSetTableAdapters.ImmobiliTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Invia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.proprietariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provaDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.immobiliBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.immobiliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // proprietariBindingSource
            // 
            this.proprietariBindingSource.DataMember = "Proprietari";
            this.proprietariBindingSource.DataSource = this.provaDataSet4;
            // 
            // provaDataSet4
            // 
            this.provaDataSet4.DataSetName = "ProvaDataSet4";
            this.provaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proprietariTableAdapter
            // 
            this.proprietariTableAdapter.ClearBeforeFill = true;
            // 
            // provaDataSet1
            // 
            this.provaDataSet1.DataSetName = "ProvaDataSet1";
            this.provaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // immobiliBindingSource1
            // 
            this.immobiliBindingSource1.DataMember = "Immobili";
            this.immobiliBindingSource1.DataSource = this.provaDataSet1;
        
            // 
            // immobiliTableAdapter1
            // 
            this.immobiliTableAdapter1.ClearBeforeFill = true;
            // 
            // immobiliBindingSource
            // 
            this.immobiliBindingSource.DataMember = "Immobili";
            this.immobiliBindingSource.DataSource = this.provaDataSet;
            // 
            // provaDataSet
            // 
            this.provaDataSet.DataSetName = "ProvaDataSet";
            this.provaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // immobiliTableAdapter
            // 
            this.immobiliTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scegli un proprietario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(346, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(346, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "CF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(346, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cognome";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(346, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefono";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(445, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(445, 122);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(445, 160);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(445, 200);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 10;
            // 
            // Invia
            // 
            this.Invia.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Invia.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Invia.Location = new System.Drawing.Point(411, 257);
            this.Invia.Name = "Invia";
            this.Invia.Size = new System.Drawing.Size(91, 35);
            this.Invia.TabIndex = 12;
            this.Invia.Text = "Invia";
            this.Invia.UseVisualStyleBackColor = false;
            this.Invia.Click += new System.EventHandler(this.Invia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(933, 416);
            this.Controls.Add(this.Invia);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "Form1";
            this.Text = "Form1";
           
            ((System.ComponentModel.ISupportInitialize)(this.proprietariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provaDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.immobiliBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.immobiliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ProvaDataSet provaDataSet;
        private System.Windows.Forms.BindingSource immobiliBindingSource;
        private ProvaDataSetTableAdapters.ImmobiliTableAdapter immobiliTableAdapter;
        private ProvaDataSet1 provaDataSet1;
        private System.Windows.Forms.BindingSource immobiliBindingSource1;
        private ProvaDataSet1TableAdapters.ImmobiliTableAdapter immobiliTableAdapter1;
        private ProvaDataSet4 provaDataSet4;
        private System.Windows.Forms.BindingSource proprietariBindingSource;
        private ProvaDataSet4TableAdapters.ProprietariTableAdapter proprietariTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button Invia;
    }
}

