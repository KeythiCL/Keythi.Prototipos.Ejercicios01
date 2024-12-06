namespace Keythi.Prototipos.Ejercicios01.DatosDeUnaPersona
{
    partial class DatosDeUnaPersonaForm
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
            button1 = new Button();
            TxtNombre = new TextBox();
            TxtApellido = new TextBox();
            TxtDocumento = new TextBox();
            TxtFechaNacimiento = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(431, 99);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(169, 50);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(138, 27);
            TxtNombre.TabIndex = 1;
            // 
            // TxtApellido
            // 
            TxtApellido.Location = new Point(313, 50);
            TxtApellido.Name = "TxtApellido";
            TxtApellido.Size = new Size(138, 27);
            TxtApellido.TabIndex = 2;
            // 
            // TxtDocumento
            // 
            TxtDocumento.Location = new Point(27, 50);
            TxtDocumento.Name = "TxtDocumento";
            TxtDocumento.Size = new Size(136, 27);
            TxtDocumento.TabIndex = 3;
            // 
            // TxtFechaNacimiento
            // 
            TxtFechaNacimiento.Location = new Point(457, 50);
            TxtFechaNacimiento.Name = "TxtFechaNacimiento";
            TxtFechaNacimiento.Size = new Size(138, 27);
            TxtFechaNacimiento.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 28);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 5;
            label1.Text = "Documento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 28);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 6;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(313, 28);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 7;
            label3.Text = "Apellido";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(457, 27);
            label4.Name = "label4";
            label4.Size = new Size(146, 20);
            label4.TabIndex = 8;
            label4.Text = "Fecha de nacimiento";
            // 
            // button2
            // 
            button2.Location = new Point(549, 99);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "Finalizar";
            button2.UseVisualStyleBackColor = true;
            // 
            // DatosDeUnaPersonaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 140);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtFechaNacimiento);
            Controls.Add(TxtDocumento);
            Controls.Add(TxtApellido);
            Controls.Add(TxtNombre);
            Controls.Add(button1);
            Name = "DatosDeUnaPersonaForm";
            Text = "DatosDeUnaPersonaForm";
            Load += DatosDeUnaPersonaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox TxtNombre;
        private TextBox TxtApellido;
        private TextBox TxtDocumento;
        private TextBox TxtFechaNacimiento;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button2;
    }
}