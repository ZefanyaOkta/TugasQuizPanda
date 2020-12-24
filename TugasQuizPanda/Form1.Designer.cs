namespace TugasQuizPanda
{
    partial class FormQuizPanda
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelKalimat = new System.Windows.Forms.Label();
            this.labelHuruf = new System.Windows.Forms.Label();
            this.labelHasil = new System.Windows.Forms.Label();
            this.labelMenjadi = new System.Windows.Forms.Label();
            this.labelHasilKalimat = new System.Windows.Forms.Label();
            this.buttonKonversi = new System.Windows.Forms.Button();
            this.textBoxKalimat = new System.Windows.Forms.TextBox();
            this.textBoxHurufAwal = new System.Windows.Forms.TextBox();
            this.textBoxHurufAkhir = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelKalimat
            // 
            this.labelKalimat.AutoSize = true;
            this.labelKalimat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKalimat.Location = new System.Drawing.Point(63, 61);
            this.labelKalimat.Name = "labelKalimat";
            this.labelKalimat.Size = new System.Drawing.Size(109, 15);
            this.labelKalimat.TabIndex = 0;
            this.labelKalimat.Text = "Masukkan Kalimat";
            // 
            // labelHuruf
            // 
            this.labelHuruf.AutoSize = true;
            this.labelHuruf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHuruf.Location = new System.Drawing.Point(63, 111);
            this.labelHuruf.Name = "labelHuruf";
            this.labelHuruf.Size = new System.Drawing.Size(97, 15);
            this.labelHuruf.TabIndex = 1;
            this.labelHuruf.Text = "Masukkan Huruf";
            // 
            // labelHasil
            // 
            this.labelHasil.AutoSize = true;
            this.labelHasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHasil.Location = new System.Drawing.Point(63, 196);
            this.labelHasil.Name = "labelHasil";
            this.labelHasil.Size = new System.Drawing.Size(41, 15);
            this.labelHasil.TabIndex = 2;
            this.labelHasil.Text = "Hasil :";
            // 
            // labelMenjadi
            // 
            this.labelMenjadi.AutoSize = true;
            this.labelMenjadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenjadi.Location = new System.Drawing.Point(325, 115);
            this.labelMenjadi.Name = "labelMenjadi";
            this.labelMenjadi.Size = new System.Drawing.Size(52, 15);
            this.labelMenjadi.TabIndex = 3;
            this.labelMenjadi.Text = "Menjadi";
            // 
            // labelHasilKalimat
            // 
            this.labelHasilKalimat.AutoSize = true;
            this.labelHasilKalimat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHasilKalimat.Location = new System.Drawing.Point(201, 198);
            this.labelHasilKalimat.Name = "labelHasilKalimat";
            this.labelHasilKalimat.Size = new System.Drawing.Size(70, 15);
            this.labelHasilKalimat.TabIndex = 4;
            this.labelHasilKalimat.Text = ". . . . . . . . . . .";
            // 
            // buttonKonversi
            // 
            this.buttonKonversi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKonversi.Location = new System.Drawing.Point(204, 153);
            this.buttonKonversi.Name = "buttonKonversi";
            this.buttonKonversi.Size = new System.Drawing.Size(300, 23);
            this.buttonKonversi.TabIndex = 5;
            this.buttonKonversi.Text = "Konversi!";
            this.buttonKonversi.UseVisualStyleBackColor = true;
            this.buttonKonversi.Click += new System.EventHandler(this.buttonKonversi_Click);
            // 
            // textBoxKalimat
            // 
            this.textBoxKalimat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKalimat.Location = new System.Drawing.Point(204, 60);
            this.textBoxKalimat.Name = "textBoxKalimat";
            this.textBoxKalimat.Size = new System.Drawing.Size(300, 21);
            this.textBoxKalimat.TabIndex = 6;
            // 
            // textBoxHurufAwal
            // 
            this.textBoxHurufAwal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHurufAwal.Location = new System.Drawing.Point(204, 110);
            this.textBoxHurufAwal.Name = "textBoxHurufAwal";
            this.textBoxHurufAwal.Size = new System.Drawing.Size(100, 21);
            this.textBoxHurufAwal.TabIndex = 7;
            // 
            // textBoxHurufAkhir
            // 
            this.textBoxHurufAkhir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHurufAkhir.Location = new System.Drawing.Point(404, 110);
            this.textBoxHurufAkhir.Name = "textBoxHurufAkhir";
            this.textBoxHurufAkhir.Size = new System.Drawing.Size(100, 21);
            this.textBoxHurufAkhir.TabIndex = 8;
            // 
            // FormQuizPanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxHurufAkhir);
            this.Controls.Add(this.textBoxHurufAwal);
            this.Controls.Add(this.textBoxKalimat);
            this.Controls.Add(this.buttonKonversi);
            this.Controls.Add(this.labelHasilKalimat);
            this.Controls.Add(this.labelMenjadi);
            this.Controls.Add(this.labelHasil);
            this.Controls.Add(this.labelHuruf);
            this.Controls.Add(this.labelKalimat);
            this.Name = "FormQuizPanda";
            this.Text = "== Quiz Panda ==";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKalimat;
        private System.Windows.Forms.Label labelHuruf;
        private System.Windows.Forms.Label labelHasil;
        private System.Windows.Forms.Label labelMenjadi;
        private System.Windows.Forms.Label labelHasilKalimat;
        private System.Windows.Forms.Button buttonKonversi;
        private System.Windows.Forms.TextBox textBoxKalimat;
        private System.Windows.Forms.TextBox textBoxHurufAwal;
        private System.Windows.Forms.TextBox textBoxHurufAkhir;
    }
}

