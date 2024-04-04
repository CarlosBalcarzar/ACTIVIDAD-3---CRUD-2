namespace SistemasVentas.VISTA.ClienteVistas
{
    partial class CLienteEliminarVistas
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
            button2 = new Button();
            button1 = new Button();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(448, 378);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(197, 38);
            button2.TabIndex = 47;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(156, 378);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(197, 38);
            button1.TabIndex = 46;
            button1.Text = "ELIMINAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(293, 282);
            textBox5.Margin = new Padding(4, 5, 4, 5);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(350, 31);
            textBox5.TabIndex = 45;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(293, 220);
            textBox4.Margin = new Padding(4, 5, 4, 5);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(350, 31);
            textBox4.TabIndex = 44;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(293, 158);
            textBox3.Margin = new Padding(4, 5, 4, 5);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(350, 31);
            textBox3.TabIndex = 43;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(293, 97);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(350, 31);
            textBox2.TabIndex = 42;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(293, 35);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(350, 31);
            textBox1.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(190, 287);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(82, 25);
            label5.TabIndex = 40;
            label5.Text = "CORREO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(240, 225);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(28, 25);
            label4.TabIndex = 39;
            label4.Text = "CI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(175, 163);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 38;
            label3.Text = "TELEFONO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 102);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 37;
            label2.Text = "APELLIDOS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(186, 40);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 36;
            label1.Text = "NOMBRE";
            // 
            // CLienteEliminarVistas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CLienteEliminarVistas";
            Text = "CLienteEliminarVistas";
            Load += CLienteEliminarVistas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}