namespace Tabla_de_multiplicacion
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
        private void InitializeComponent()
        {
            label1 = new Label();
            btn_Limpiar = new Button();
            lst_tabla = new ListBox();
            btn_Mostrar = new Button();
            lbl_Ingresar_Numero = new Label();
            btn_Salir = new Button();
            txt_Numero = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Castellar", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(171, 44);
            label1.Name = "label1";
            label1.Size = new Size(215, 19);
            label1.TabIndex = 13;
            label1.Text = "TABLA_MULTIPLICAR";
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.BackColor = Color.Azure;
            btn_Limpiar.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btn_Limpiar.Location = new Point(580, 194);
            btn_Limpiar.Name = "btn_Limpiar";
            btn_Limpiar.Size = new Size(86, 35);
            btn_Limpiar.TabIndex = 12;
            btn_Limpiar.Text = "Limpiar";
            btn_Limpiar.UseVisualStyleBackColor = false;
            btn_Limpiar.Click += btn_Limpiar_Click;
            // 
            // lst_tabla
            // 
            lst_tabla.FormattingEnabled = true;
            lst_tabla.ItemHeight = 15;
            lst_tabla.Location = new Point(104, 76);
            lst_tabla.Name = "lst_tabla";
            lst_tabla.Size = new Size(371, 274);
            lst_tabla.TabIndex = 11;
            // 
            // btn_Mostrar
            // 
            btn_Mostrar.BackColor = Color.Azure;
            btn_Mostrar.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btn_Mostrar.Location = new Point(580, 148);
            btn_Mostrar.Name = "btn_Mostrar";
            btn_Mostrar.Size = new Size(86, 35);
            btn_Mostrar.TabIndex = 10;
            btn_Mostrar.Text = "Mostrar";
            btn_Mostrar.UseVisualStyleBackColor = false;
            btn_Mostrar.Click += btn_Mostrar_Click;
            // 
            // lbl_Ingresar_Numero
            // 
            lbl_Ingresar_Numero.AutoSize = true;
            lbl_Ingresar_Numero.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lbl_Ingresar_Numero.Location = new Point(550, 63);
            lbl_Ingresar_Numero.Name = "lbl_Ingresar_Numero";
            lbl_Ingresar_Numero.Size = new Size(128, 19);
            lbl_Ingresar_Numero.TabIndex = 9;
            lbl_Ingresar_Numero.Text = "Ingresar_Numero";
            // 
            // btn_Salir
            // 
            btn_Salir.BackColor = Color.AliceBlue;
            btn_Salir.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btn_Salir.Location = new Point(12, 28);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(86, 35);
            btn_Salir.TabIndex = 8;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = false;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // txt_Numero
            // 
            txt_Numero.Location = new Point(566, 98);
            txt_Numero.Name = "txt_Numero";
            txt_Numero.Size = new Size(112, 23);
            txt_Numero.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(715, 394);
            Controls.Add(label1);
            Controls.Add(btn_Limpiar);
            Controls.Add(lst_tabla);
            Controls.Add(btn_Mostrar);
            Controls.Add(lbl_Ingresar_Numero);
            Controls.Add(btn_Salir);
            Controls.Add(txt_Numero);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_Limpiar;
        private ListBox lst_tabla;
        private Button btn_Mostrar;
        private Label lbl_Ingresar_Numero;
        private Button btn_Salir;
        private TextBox txt_Numero;
    }
}
