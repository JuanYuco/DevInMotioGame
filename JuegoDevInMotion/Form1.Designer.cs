namespace JuegoDevInMotion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>

        Label accionesText;
        private void InitializeComponent()
        {
            this.armas = new System.Windows.Forms.ComboBox();
            this.contexturas = new System.Windows.Forms.ComboBox();
            this.accionesText = new System.Windows.Forms.Label();
            this.atacar = new System.Windows.Forms.Button();
            this.correr = new System.Windows.Forms.Button();
            this.saltar = new System.Windows.Forms.Button();
            this.estamina = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // armas
            // 
            this.armas.Location = new System.Drawing.Point(100, 50);
            this.armas.Name = "armas";
            this.armas.Size = new System.Drawing.Size(200, 23);
            this.armas.TabIndex = 0;
            this.armas.SelectedIndexChanged += ArmasOnChanged;
            // 
            // contexturas
            // 
            this.contexturas.Location = new System.Drawing.Point(500, 50);
            this.contexturas.Name = "contexturas";
            this.contexturas.Size = new System.Drawing.Size(200, 23);
            this.contexturas.TabIndex = 1;
            this.contexturas.SelectedIndexChanged += CotexturaOnChanged;
            // 
            // accionesText
            // 
            this.accionesText.BackColor = System.Drawing.Color.Gray;
            this.accionesText.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accionesText.ForeColor = System.Drawing.Color.White;
            this.accionesText.Location = new System.Drawing.Point(200, 100);
            this.accionesText.Name = "accionesText";
            this.accionesText.Size = new System.Drawing.Size(400, 150);
            this.accionesText.TabIndex = 2;
            this.accionesText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.estamina.BackColor = System.Drawing.Color.Gray;
            this.estamina.Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.estamina.ForeColor = System.Drawing.Color.White;
            this.estamina.Location = new System.Drawing.Point(350, 50);
            this.estamina.Name = "accionesText";
            this.estamina.Size = new System.Drawing.Size(100, 50);
            this.estamina.TabIndex = 2;
            this.estamina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // atacar
            // 
            this.atacar.Location = new System.Drawing.Point(250, 300);
            this.atacar.Name = "atacar";
            this.atacar.Size = new System.Drawing.Size(100, 23);
            this.atacar.TabIndex = 3;
            this.atacar.Text = "Atacar";
            this.atacar.Click += OnAtacar;
            // 
            // correr
            // 
            this.correr.Location = new System.Drawing.Point(360, 300);
            this.correr.Name = "correr";
            this.correr.Size = new System.Drawing.Size(100, 23);
            this.correr.TabIndex = 4;
            this.correr.Text = "Correr";
            this.correr.Click += OnCorrer;
            // 
            // saltar
            // 
            this.saltar.Location = new System.Drawing.Point(470, 300);
            this.saltar.Name = "saltar";
            this.saltar.Size = new System.Drawing.Size(100, 23);
            this.saltar.TabIndex = 5;
            this.saltar.Text = "Saltar";
            this.saltar.Click += OnSaltar;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.armas);
            this.Controls.Add(this.contexturas);
            this.Controls.Add(this.accionesText);
            this.Controls.Add(this.atacar);
            this.Controls.Add(this.correr);
            this.Controls.Add(this.saltar);
            this.Controls.Add(this.estamina);
            this.Name = "Form1";
            this.Text = "Juego";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox armas;
        private ComboBox contexturas;
        private Button atacar;
        private Button correr;
        private Button saltar;
        private Label estamina;
    }
}