namespace ANGGKT_beadando
{
    partial class UserControl3
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.nevtext = new System.Windows.Forms.TextBox();
            this.korText = new System.Windows.Forms.TextBox();
            this.telotext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cicaDataSet1 = new ANGGKT_beadando.CicaDataSet();
            this.cICABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cICATableAdapter = new ANGGKT_beadando.CicaDataSetTableAdapters.CICATableAdapter();
            this.tableAdapterManager = new ANGGKT_beadando.CicaDataSetTableAdapters.TableAdapterManager();
            this.nevlabel = new System.Windows.Forms.Label();
            this.korlabel = new System.Windows.Forms.Label();
            this.telefonszamlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cicaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cICABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Örökbefogadási ív";
            // 
            // nevtext
            // 
            this.nevtext.Location = new System.Drawing.Point(280, 283);
            this.nevtext.Name = "nevtext";
            this.nevtext.Size = new System.Drawing.Size(230, 26);
            this.nevtext.TabIndex = 1;
            this.nevtext.TextChanged += new System.EventHandler(this.nevtext_TextChanged);
            this.nevtext.Validating += new System.ComponentModel.CancelEventHandler(this.nevtext_Validating);
            // 
            // korText
            // 
            this.korText.Location = new System.Drawing.Point(280, 344);
            this.korText.Name = "korText";
            this.korText.Size = new System.Drawing.Size(230, 26);
            this.korText.TabIndex = 2;
            this.korText.TextChanged += new System.EventHandler(this.korText_TextChanged);
            this.korText.Validating += new System.ComponentModel.CancelEventHandler(this.korText_Validating);
            // 
            // telotext
            // 
            this.telotext.Location = new System.Drawing.Point(280, 408);
            this.telotext.Name = "telotext";
            this.telotext.Size = new System.Drawing.Size(230, 26);
            this.telotext.TabIndex = 3;
            this.telotext.TextChanged += new System.EventHandler(this.telotext_TextChanged);
            this.telotext.Validating += new System.ComponentModel.CancelEventHandler(this.telotext_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Papyrus", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Név:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Papyrus", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(200, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Papyrus", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(136, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefonszám:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Papyrus", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(171, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(365, 56);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ahhoz, hogy véglegesíts az örökbefogadásod,\r\n kérlek, add meg további adataidat! " +
    ":)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 522);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCyan;
            this.button1.Font = new System.Drawing.Font("Papyrus", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(389, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 61);
            this.button1.TabIndex = 9;
            this.button1.Text = "Véglegesítés";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCyan;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Papyrus", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(234, 481);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 60);
            this.button2.TabIndex = 10;
            this.button2.Text = "Mégse";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 597);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "label7";
            // 
            // cicaDataSet1
            // 
            this.cicaDataSet1.DataSetName = "CicaDataSet";
            this.cicaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cICABindingSource
            // 
            this.cICABindingSource.DataMember = "CICA";
            this.cICABindingSource.DataSource = this.cicaDataSet1;
            // 
            // cICATableAdapter
            // 
            this.cICATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CICATableAdapter = this.cICATableAdapter;
            this.tableAdapterManager.GazdaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ANGGKT_beadando.CicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nevlabel
            // 
            this.nevlabel.AutoSize = true;
            this.nevlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nevlabel.ForeColor = System.Drawing.Color.Red;
            this.nevlabel.Location = new System.Drawing.Point(516, 271);
            this.nevlabel.Name = "nevlabel";
            this.nevlabel.Size = new System.Drawing.Size(319, 40);
            this.nevlabel.TabIndex = 34;
            this.nevlabel.Text = "Kérlek ebben a formátumban add meg \r\na neved: Nagy Anna (példa)";
            this.nevlabel.Visible = false;
            // 
            // korlabel
            // 
            this.korlabel.AutoSize = true;
            this.korlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.korlabel.ForeColor = System.Drawing.Color.Red;
            this.korlabel.Location = new System.Drawing.Point(516, 344);
            this.korlabel.Name = "korlabel";
            this.korlabel.Size = new System.Drawing.Size(261, 20);
            this.korlabel.TabIndex = 35;
            this.korlabel.Text = "0-99-ig adhatod meg a korodat!";
            this.korlabel.Visible = false;
            // 
            // telefonszamlabel
            // 
            this.telefonszamlabel.AutoSize = true;
            this.telefonszamlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.telefonszamlabel.ForeColor = System.Drawing.Color.Red;
            this.telefonszamlabel.Location = new System.Drawing.Point(516, 408);
            this.telefonszamlabel.Name = "telefonszamlabel";
            this.telefonszamlabel.Size = new System.Drawing.Size(341, 40);
            this.telefonszamlabel.TabIndex = 36;
            this.telefonszamlabel.Text = "Kérlek ebben a formátumban add meg \r\na telefonszámod: 06-30-666-8888 (példa)";
            this.telefonszamlabel.Visible = false;
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Controls.Add(this.telefonszamlabel);
            this.Controls.Add(this.korlabel);
            this.Controls.Add(this.nevlabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.telotext);
            this.Controls.Add(this.korText);
            this.Controls.Add(this.nevtext);
            this.Controls.Add(this.label1);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(1035, 880);
            ((System.ComponentModel.ISupportInitialize)(this.cicaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cICABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nevtext;
        private System.Windows.Forms.TextBox korText;
        private System.Windows.Forms.TextBox telotext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private CicaDataSet cicaDataSet1;
        private System.Windows.Forms.BindingSource cICABindingSource;
        private CicaDataSetTableAdapters.CICATableAdapter cICATableAdapter;
        private CicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label nevlabel;
        private System.Windows.Forms.Label korlabel;
        private System.Windows.Forms.Label telefonszamlabel;
    }
}
